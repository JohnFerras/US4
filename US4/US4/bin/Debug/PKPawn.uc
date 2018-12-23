/**
 * Base class for all characters in PKHD
 * 
 * (c) 2012 The Farm 51
 */
class PKPawn extends EvilPawn
	native(Pawn)
	dependson(PKTypes);

/** If true, this pawn is a boss (duh) */
var() config bool bIsBoss;

/** Reference to the current PKAIController */
var PKAIController MyPKAI;

/** object of this class will be spawned when body disappear */
var class<PainItem_Energy>    SoulItemClass;
var class<PainItem_Energy>    RedSoulItemClass;

/** This pawn wont be countable */
var config bool bNotCountable;

/** This Pawn will throw soul */
var config bool bThrowSoul;

/** Soul will be bigger (red) */
var config bool bThrowRedSoul;


/** How much HitLocation will be shifted by (-Momentum) direction*/
var config float InstantGibOriginShiftX;

/** How much origin will be raised*/
var config float InstantGibOriginShiftZ;

/** This is radial strength*/
var config float InstantGibForce;




simulated function PostBeginPlay()
{	
	super.PostBeginPlay();

	if (Physics == PHYS_Flying)
	{
		Mesh.bRootMotionExtractedNotify = true;
	}
	
}

defaultproperties
{
	//pbak: default implementation of playing impact sounds is disabled
	//but i use parameters from UDKPawn FallImpactSound and FallSpeedThreshold
	bCanPlayFallingImpacts=false
	//generic for all pawns
	FallSpeedThreshold=150.0

	WalkableFloorZ=0.6f

	DefaultAirControl=1.f
	

	Begin Object Name=CollisionCylinder
		CollisionRadius=+0020.000000
		CollisionHeight=+0057.000000
	End Object

	Begin Object Name=WPawnSkeletalMeshComponent
		Translation=(Z=-60)
		RBCollideWithChannels=(Default=TRUE,Pawn=TRUE,DeadPawn=TRUE,BlockingVolume=TRUE,EffectPhysics=TRUE,FracturedMeshPart=TRUE,SoftBody=TRUE,Untitled3=False)
		SkipLodModel=1
	End Object

	Begin Object Class=StaticMeshComponent Name=ProjectileStaticMesh
		Scale3D=(X=1.0,Y=1.0,Z=1.0)
		BlockActors=false
		HiddenGame=true
	End Object
	ProjectileSM=ProjectileStaticMesh

	Begin Object Class=ParticleSystemComponent Name=ProjectileEffect
		bAutoActivate=false
	End Object
	ProjectilePSC=ProjectileEffect

	InventoryManagerClass=class'PKInventoryManager'

	DetachingLimbSoundCue=SoundCue'a_ImpactsFlesh.Cue.gib_part'
	DetachingLimbBySoulSawSoundCue=SoundCue'a_SoulReaper.Cue.a_DiscHitMeat'
	FullGibSoundCue=SoundCue'a_ImpactsFlesh.Cue.gib_big'
	FullFrozenGibSoundCue=SoundCue'a_ImpactsFlesh.Cue.gib_frozen'

	GibFrozenImpactSoundCue=SoundCue'a_ImpactsFlesh.Cue.meat_frozen-splash'
	GibImpactSoundCue=SoundCue'a_ImpactsFlesh.Cue.meat-splash'
	GibImpactDecalMaterials(0)=MaterialInstanceTimeVarying'ps_Blood.Decals.m_ps_BloodDecal_Ver1'
	GibImpactDecalMaterials(1)=MaterialInstanceTimeVarying'ps_Blood.Decals.m_ps_BloodDecal_Ver2'
	GibImpactDecalMaterials(2)=MaterialInstanceTimeVarying'ps_Blood.Decals.m_ps_BloodDecal_Ver3'
	GibImpactDecalMaterials(3)=MaterialInstanceTimeVarying'ps_Blood.Decals.m_ps_BloodDecal_Ver4'
	GibImpactParticleSystem=ParticleSystem'ps_Blood.Effects.ps_Bloodhit_GibExplo'

	HeadBone=Head

	PawnActionClasses.Empty

	PawnActionClasses(PA_FullBodyHitReaction)=class'PPA_FullBodyHitReaction'
	PawnActionClasses(PA_TopBodyHalfHitReaction)=class'EPA_TopBodyHalfHitReaction'
	PawnActionClasses(PA_DeathAnim)=class'EPA_DeathAnim'
	PawnActionClasses(PA_DeathAnimWithoutMotors)=class'EPA_DeathAnimWithoutMotors'
	PawnActionClasses(PA_BurnDeathAnim)=class'EPA_BurningAnim'	
	PawnActionClasses(PA_Melee)=class'PPA_Melee'
	PawnActionClasses(PA_Charge)=class'PPA_Charge'
	PawnActionClasses(PA_Throw)=class'PPA_Throw'
	PawnActionClasses(PA_RecoverFromRagdoll)=class'EPA_RecoverFromRagdoll'
	PawnActionClasses(PA_Emerge)=class'EPA_Emerge'
	PawnActionClasses(PA_ZombieScream)=class'EPA_FastSpinUp'
	PawnActionClasses(PA_AnimControl)=class'EPA_AnimControl'
	PawnActionClasses(PA_ChargeFail)=class'EPA_ChargeFail'

	PawnActionClasses(PA_Aim)=class'EPA_Aim'
	PawnActionClasses(PA_Shoot)=class'PPA_Shoot'
	PawnActionClasses(PA_Reload)=class'EPA_Reload'

	PawnActionClasses(PA_Frozen)=class'PPA_Frozen'
	PawnActionClasses(PA_FarAttackPrepare)=class'PPA_FarAttackPrepare'
	PawnActionClasses(PA_Scream)=class'PPA_Scream'

	PawnActionClasses(PA_Jump)=class'PPA_Jump'
	PawnActionClasses(PA_PreJump)=class'EPA_BasePlaySingleASTAnim'

	PKMaterialAtlasArchetype=PKMaterialAtlas'MaterialsAtlas_ch.Archetypes.MaterialsAtlas_Generic'


	WeaponSocket=WeaponPoint

	ClothesSettings=none

	bShouldPlayDeathAnimationToRagdoll=true
	bCanStrafe=true
	bHasDirectionalMoveAnims=false

	// body disappearing
	BodyExplosionSound=SoundCue'a_MonsterDefault.Cue.monster_body_explosion'
	BodyExplosionPS=ParticleSystem'ps_all_Levels.Effects.ps_ch_MorphToSoul' 
	BodyExplosionNoSoulPS=ParticleSystem'ps_all_Levels.Effects.ps_ch_MorphToSoulEnclave'

	// frozen effects
	FrozenEffectPS=ParticleSystem'ps_wp_Shotgun.Effects.ps_ch_Freeze'
	FrozenLightArchetype=EvilLightActor'ps_wp_Shotgun.ar_wp_FreezerLightChar'
		
	// burning effects
	BurnEffectPS=ParticleSystem'ps_FireEffects.Effects.ps_ch_Burning'
	BurnEffectPS_NoGore=ParticleSystem'ps_FireEffects.Effects.ps_ch_Burning_noGore'
	CapturedEffectPS=ParticleSystem'ps_ch_Captured.Effects.ps_ch_Plazma'


	ElectricityEffectPS=ParticleSystem'ps_wp_Electrodriver.Effects.ps_ch_Electro'
	SoulReaperEffectPS=ParticleSystem'ps_wp_SoulReaper.Effects.ps_ch_Soul'

	// demon mode parent material
	DemonModeMaterial=Material'PP_PKHD.Materials.DemonVisionMonsterMaterial'

	SoulEffectPS=ParticleSystem'ps_all_Levels.Effects.ps_ch_SkeletonWithSoul'
	

	TurnInPlaceWhileMovingYawThreshold=256

	SoulItemClass=class'PainItem_Energy'
	RedSoulItemClass=class'PainItem_EnergyRed'

	TimeToBodyDisappear=7
	
	MaxStepHeight=45.0

	bCanBeKnockedDown=true
	bDetachingLimbsWhenDiedEnabled=true

	DefaultImpactMaterial=PhysicalMaterial'pm_materials.PM_Flesh'

	DetachingLimbSoundLimiter=1
	DetachingSpecificLimbEnabled=false

	ElectricityConvulsionsBones(0)="LeftForeArm"
	ElectricityConvulsionsBones(1)="RightForeArm"
	ElectricityConvulsionsBones(2)="Hips"
	ElectricityConvulsionsBones(3)="LeftLeg"
	ElectricityConvulsionsBones(4)="RightLeg"
	ElectricityConvulsionsBones(5)="Head"

	SparksSoundCues(0)=SoundCue'a_ElectroDriver.Cue.electro-shoot-spark1'
	SparksSoundCues(1)=SoundCue'a_ElectroDriver.Cue.electro-shoot-spark2'
	SparksSoundCues(2)=SoundCue'a_ElectroDriver.Cue.electro-shoot-spark3'


	FallImpactSound=SoundCue'a_PlayerMP.Cue.Body_Falls'
	bGetAdjustedAimFromSocket=true

	bCanBePinned=true
	Mass=100

	bSpawnNextPawnWhenBodyDisapear=true

	bAimWhenFullBodySlotAnim=true

	bPlayHitSoundInPlayHit=false

	bCanPickupInventory=false

`if(`isdefined(CONSOLE))
	GibImpactSoundLimitCount=2
	GibImpactDecalLimitCount=2
	GibImpactPSLimitCount=2
`else
	GibImpactSoundLimitCount=3
	GibImpactDecalLimitCount=8
	GibImpactPSLimitCount=8
`endif
}



