/**
 * Base class for all characters in PKHD
 * 
 * (c) 2012 The Farm 51
 */
#include "PKPawn.h"
#include "Pawn.h"

void PKPawn::PostBeginPlay()
{
	Super::PostBeginPlay();

	if (Physics == PHYS_Flying)
	{
		Mesh->bRootMotionExtractedNotify = true;
	}
}