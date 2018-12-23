
/**
 * Base class for all characters in PKHD
 * 
 * (c) 2012 The Farm 51
 */
 #pragma once

 #include "PKTypes.h"
 #include "Pawn.h"
 #include "EvilPawn.h"

UCLASS()
class PROJECT_API PKPawn :  public EvilPawn
{

	public:
	/** If true, this pawn is a boss (duh) */
	UPROPERTY(Config)
	bool bIsBoss;

	/** Reference to the current PKAIController */
	PKAIController* MyPKAI;

	/** object of this class will be spawned when body disappear */
	TSubclassOf<PainItem_Energy>    SoulItemClass;
	TSubclassOf<PainItem_Energy>    RedSoulItemClass;

	/** This pawn wont be countable */
	UPROPERTY(Config)
	bool bNotCountable;

	/** This Pawn will throw soul */
	UPROPERTY(Config)
	bool bThrowSoul;

	/** Soul will be bigger (red) */
	UPROPERTY(Config)
	bool bThrowRedSoul;


	/** How much HitLocation will be shifted by (-Momentum) direction*/
	UPROPERTY(Config)
	float InstantGibOriginShiftX;

	/** How much origin will be raised*/
	UPROPERTY(Config)
	float InstantGibOriginShiftZ;

	/** This is radial strength*/
	UPROPERTY(Config)
	float InstantGibForce;



	void PostBeginPlay();




};