Rem ------------------------------------------------------------------------
Rem St7API.DLL - Constants
Rem ------------------------------------------------------------------------

Module St7APIConst

    Public Const kMaxStrLen As Int32 = 255

    Rem Array Limits
    Public Const kMaxEntityTotals As Int32 = 4
    Public Const kMaxElementNode As Int32 = 20
    Public Const kMaxBeamResult As Int32 = 4096
    Public Const kNumBeamSectionData As Int32 = 20
    Public Const kNumMaterialData As Int32 = 3
    Public Const kMaxAttributeDoubles As Int32 = 12
    Public Const kMaxAttributeLogicals As Int32 = 6
    Public Const kMaxAttributeLongint As Int32 = 6
    Public Const kLastUnit As Int32 = 6

    Rem Unit Positions
    Public Const ipLENGTHU As Int32 = 0
    Public Const ipFORCEU As Int32 = 1
    Public Const ipSTRESSU As Int32 = 2
    Public Const ipMASSU As Int32 = 3
    Public Const ipTEMPERU As Int32 = 4
    Public Const ipENERGYU As Int32 = 5

    Rem Unit Types - LENGTH
    Public Const luMETRE As Int32 = 0
    Public Const luCENTIMETRE As Int32 = 1
    Public Const luMILLIMETRE As Int32 = 2
    Public Const luFOOT As Int32 = 3
    Public Const luINCH As Int32 = 4

    Rem Unit Types - FORCE
    Public Const fuNEWTON As Int32 = 0
    Public Const fuKILONEWTON As Int32 = 1
    Public Const fuMEGANEWTON As Int32 = 2
    Public Const fuKILOFORCE As Int32 = 3
    Public Const fuPOUNDFORCE As Int32 = 4
    Public Const fuTONNEFORCE As Int32 = 5
    Public Const fuKIPFORCE As Int32 = 6

    Rem Unit Types - STRESS
    Public Const suPASCAL As Int32 = 0
    Public Const suKILOPASCAL As Int32 = 1
    Public Const suMEGAPASCAL As Int32 = 2
    Public Const suKSCm As Int32 = 3
    Public Const suPSI As Int32 = 4
    Public Const suKSI As Int32 = 5
    Public Const suPSF As Int32 = 6

    Rem Unit Types - MASS
    Public Const muKILOGRAM As Int32 = 0
    Public Const muTONNE As Int32 = 1
    Public Const muGRAM As Int32 = 2
    Public Const muPOUND As Int32 = 3
    Public Const muSLUG As Int32 = 4

    Rem Unit Types - TEMPERATURE
    Public Const tuCELSIUS As Int32 = 0
    Public Const tuFAHRENHEIT As Int32 = 1
    Public Const tuKELVIN As Int32 = 2

    Rem Unit Types - ENERGY
    Public Const euJOULE As Int32 = 0
    Public Const euBTU As Int32 = 1
    Public Const euFTLBF As Int32 = 2
    Public Const euCALORIE As Int32 = 3

    Rem Unit Types - TIME
    Public Const tuMilliSec As Int32 = 0
    Public Const tuSec As Int32 = 1
    Public Const tuMin As Int32 = 2
    Public Const tuHour As Int32 = 3
    Public Const tuDay As Int32 = 4

    Rem Entity Types
    Public Const tyNULL As Int32 = -1
    Public Const tyNODE As Int32 = 0
    Public Const tyBEAM As Int32 = 1
    Public Const tyPLATE As Int32 = 2
    Public Const tyBRICK As Int32 = 3
    Public Const tyLINK As Int32 = 4
    Public Const tyVERTEX As Int32 = 5
    Public Const tyGEOMETRYEDGE As Int32 = 6
    Public Const tyGEOMETRYFACE As Int32 = 7
    Public Const tyLOADPATH As Int32 = 8

    Rem Link Types
    Public Const ilMasterSlaveLink As Int32 = 1
    Public Const ilSectorSymmetryLink As Int32 = 2
    Public Const ilCouplingLink As Int32 = 3
    Public Const ilPinnedLink As Int32 = 4
    Public Const ilRigidLink As Int32 = 5
    Public Const ilShrinkLink As Int32 = 6
    Public Const ilTwoPointLink As Int32 = 7
    Public Const ilAttachmentLink As Int32 = 8
    Public Const ilMultiPointLink As Int32 = 9

    Rem Master-Slave Link
    Public Const msFree As Int32 = 0
    Public Const msFix As Int32 = 1
    Public Const msFixNegate As Int32 = -1

    Rem Coupling, Attachment and Multi-Point Links
    Public Const cpTranslational As Int32 = 1
    Public Const cpRotational As Int32 = 2
    Public Const cpBoth As Int32 = 3

    Rem Rigid Link
    Public Const rgPlaneXYZ As Int32 = 0
    Public Const rgPlaneXY As Int32 = 1
    Public Const rgPlaneYZ As Int32 = 2
    Public Const rgPlaneZX As Int32 = 3

    Rem 2-Point Link
    Public Const ipTwoPointDOF1 As Int32 = 0
    Public Const ipTwoPointDOF2 As Int32 = 1
    Public Const ipTwoPointUCS1 As Int32 = 2
    Public Const ipTwoPointUCS2 As Int32 = 3
    Public Const ipTwoPointC0 As Int32 = 0
    Public Const ipTwoPointC1 As Int32 = 1
    Public Const ipTwoPointC2 As Int32 = 2

    Rem Attachment Link
    Public Const ipAttachmentElType As Int32 = 0
    Public Const ipAttachmentElNum As Int32 = 1
    Public Const ipAttachmentBrickFaceNum As Int32 = 2
    Public Const ipAttachmentCouple As Int32 = 3

    Rem Multi-Point Link
    Public Const mpInterpolatedFactors As Int32 = 1
    Public Const mpUserFactors As Int32 = 2

    Rem Node Temperature Types
    Public Const tReferenceTemperature As Int32 = 0
    Public Const tFixedTemperature As Int32 = 1
    Public Const tInitialTemperature As Int32 = 2
    Public Const tTableTemperature As Int32 = 3

    Rem Beam End Release Constants
    Public Const kBeamEndRelReleased As Int32 = 0
    Public Const kBeamEndRelFixed As Int32 = 1
    Public Const kBeamEndRelPartial As Int32 = 2

    Rem Property Types
    Public Const ptBEAMPROP As Int32 = 1
    Public Const ptPLATEPROP As Int32 = 2
    Public Const ptBRICKPROP As Int32 = 3
    Public Const ptPLYPROP As Int32 = 4

    Rem Property Totals
    Public Const ipBeamPropTotal As Int32 = 0
    Public Const ipPlatePropTotal As Int32 = 1
    Public Const ipBrickPropTotal As Int32 = 2
    Public Const ipPlyPropTotal As Int32 = 3

    Rem Alpha Temperature Types
    Public Const kIntegratedAlpha As Int32 = 0
    Public Const kInstantAlpha As Int32 = 1

    Rem Sampling Positions
    Public Const AtCentroid As Int32 = 0
    Public Const AtGaussPoints As Int32 = 1
    Public Const AtNodesAverageNever As Int32 = 2
    Public Const AtNodesAverageAll As Int32 = 3
    Public Const AtNodesAverageSame As Int32 = 4

    Rem Beam Types
    Public Const kBeamTypeNull As Int32 = 0
    Public Const kBeamTypeSpring As Int32 = 1
    Public Const kBeamTypeCable As Int32 = 2
    Public Const kBeamTypeTruss As Int32 = 3
    Public Const kBeamTypeCutoff As Int32 = 4
    Public Const kBeamTypeContact As Int32 = 5
    Public Const kBeamTypeBeam As Int32 = 6
    Public Const kBeamTypeUser As Int32 = 7
    Public Const kBeamTypePipe As Int32 = 8
    Public Const kBeamTypeConnection As Int32 = 9

    Rem Contact Types
    Public Const kZeroGapContact As Int32 = 0
    Public Const kNormalContact As Int32 = 1
    Public Const kTensionContact As Int32 = 2
    Public Const kTakeupContact As Int32 = 3

    Rem Contact Sub Types
    Public Const kTensionTakeup As Int32 = 0
    Public Const kCompressionTakeup As Int32 = 1

    Rem Cutoff Types
    Public Const kBrittleGap As Int32 = 0
    Public Const kDuctileGap As Int32 = 1

    Rem Contact Parameters Positions - Integers
    Public Const ipContactType As Int32 = 0
    Public Const ipDynamicStiffness As Int32 = 1
    Public Const ipUseInFirstIteration As Int32 = 2
    Public Const ipUpdateDirection As Int32 = 3
    Public Const ipContactSubType As Int32 = 4
    Public Const ipFrictionYieldType As Int32 = 5
    Public Const ipFrictionModel As Int32 = 6
    Public Const ipTensionLateralStiffness As Int32 = 7

    Rem Contact Parameters Positions - Doubles
    Public Const ipContactStiffness As Int32 = 0
    Public Const ipFrictionC1 As Int32 = 1
    Public Const ipFrictionC2 As Int32 = 2
    Public Const ipContactMaxTension As Int32 = 3

    Rem CutoffBar Parameter Positions
    Public Const ipCutoffType As Int32 = 0
    Public Const ipKeepMass As Int32 = 1

    Rem Library Types
    Public Const lbMaterial As Int32 = 0
    Public Const lbBeamSection As Int32 = 1
    Public Const lbComposite As Int32 = 2
    Public Const lbReinforcementLayout As Int32 = 3
    Public Const lbCreepDefinition As Int32 = 4
    Public Const lbLoadPathTemplate As Int32 = 5

    Rem Beam Section Types
    Public Const kNullSection As Int32 = 0
    Public Const kCircularSolid As Int32 = 1
    Public Const kCircularHollow As Int32 = 2
    Public Const kSquareSolid As Int32 = 3
    Public Const kSquareHollow As Int32 = 4
    Public Const kLipChannel As Int32 = 5
    Public Const kTopHatChannel As Int32 = 6
    Public Const kISection As Int32 = 7
    Public Const kTSection As Int32 = 8
    Public Const kLSection As Int32 = 9
    Public Const kZSection As Int32 = 10
    Public Const kUserSection As Int32 = 11
    Public Const kTrapezoidSolid As Int32 = 12
    Public Const kTrapezoidHollow As Int32 = 13
    Public Const kTriangleSolid As Int32 = 14
    Public Const kTriangleHollow As Int32 = 15
    Public Const kCruciform As Int32 = 16

    Rem Beam Mirror Types
    Public Const kMirrorNone As Int32 = 0
    Public Const kMirrorTop As Int32 = 1
    Public Const kMirrorBot As Int32 = 2
    Public Const kMirrorLeft As Int32 = 3
    Public Const kMirrorRight As Int32 = 4
    Public Const kMirrorLeftAndTop As Int32 = 5
    Public Const kMirrorLeftAndBot As Int32 = 6
    Public Const kMirrorRightAndTop As Int32 = 7
    Public Const kMirrorRightAndBot As Int32 = 8
    Public Const kMirrorLeftTopOnly As Int32 = 9
    Public Const kMirrorLeftBotOnly As Int32 = 10
    Public Const kMirrorRightTopOnly As Int32 = 11
    Public Const kMirrorRightBotOnly As Int32 = 12

    Rem Beam Section Positions
    Public Const ipAREA As Int32 = 0
    Public Const ipI11 As Int32 = 1
    Public Const ipI22 As Int32 = 2
    Public Const ipJ As Int32 = 3
    Public Const ipSL1 As Int32 = 4
    Public Const ipSL2 As Int32 = 5
    Public Const ipSA1 As Int32 = 6
    Public Const ipSA2 As Int32 = 7
    Public Const ipXBAR As Int32 = 8
    Public Const ipYBAR As Int32 = 9
    Public Const ipANGLE As Int32 = 10
    Public Const ipD1 As Int32 = 11
    Public Const ipD2 As Int32 = 12
    Public Const ipD3 As Int32 = 13
    Public Const ipT1 As Int32 = 14
    Public Const ipT2 As Int32 = 15
    Public Const ipT3 As Int32 = 16
    Public Const ipGapA As Int32 = 17
    Public Const ipGapB As Int32 = 18

    Rem Beam Load Types
    Public Const kMaxDLPerBeam As Int32 = 64
    Public Const kConstantDL As Int32 = 0
    Public Const kLinearDL As Int32 = 1
    Public Const kTriangularDL As Int32 = 2
    Public Const kThreePoint0DL As Int32 = 3
    Public Const kThreePoint1DL As Int32 = 4
    Public Const kTrapezoidalDL As Int32 = 5

    Rem Plate Load Patch Types
    Public Const ptAuto4 As Int32 = 0
    Public Const ptAuto3 As Int32 = 1
    Public Const ptAuto2 As Int32 = 2
    Public Const ptAuto1 As Int32 = 3
    Public Const ptAngleSplit As Int32 = 4
    Public Const ptManual As Int32 = 5

    Rem Plate Types
    Public Const kPlateTypeNull As Int32 = 0
    Public Const kPlateTypePlaneStress As Int32 = 1
    Public Const kPlateTypePlaneStrain As Int32 = 2
    Public Const kPlateTypeAxisymmetric As Int32 = 3
    Public Const kPlateTypePlateShell As Int32 = 4
    Public Const kPlateTypeShearPanel As Int32 = 5
    Public Const kPlateTypeMembrane As Int32 = 6
    Public Const kPlateTypeLoadPatch As Int32 = 7

    Rem Geometry Surface Types
    Public Const suPlane As Int32 = 0
    Public Const suSphere As Int32 = 1
    Public Const suTorus As Int32 = 2
    Public Const suCone As Int32 = 3
    Public Const suBSpline As Int32 = 4
    Public Const suRotSur As Int32 = 5
    Public Const suPipeSur As Int32 = 6
    Public Const suSumSur As Int32 = 7
    Public Const suTabCyl As Int32 = 8
    Public Const suRuleSur As Int32 = 9
    Public Const suCubicSpline As Int32 = 10

    Rem Plate Section Positions
    Public Const ipTHICKM As Int32 = 0
    Public Const ipTHICKB As Int32 = 1

    Rem Material Types
    Public Const kMaterialTypeNull As Int32 = 0
    Public Const kMaterialTypeIsotropic As Int32 = 1
    Public Const kMaterialTypeOrthotropic As Int32 = 2
    Public Const kMaterialTypeAnisotropic As Int32 = 3
    Public Const kMaterialTypeRubber As Int32 = 4
    Public Const kMaterialTypeSoil As Int32 = 5
    Public Const kMaterialTypeLaminate As Int32 = 6
    Public Const kMaterialTypeUserDefined As Int32 = 7
    Public Const kMaterialTypePly As Int32 = 8
    Public Const kMaterialTypeFluid As Int32 = 10

    Rem Yield Criteria
    Public Const ycTresca As Int32 = 0
    Public Const ycVonMises As Int32 = 1
    Public Const ycMaxStress As Int32 = 2
    Public Const ycMohrCoulomb As Int32 = 3
    Public Const ycDruckerPrager As Int32 = 4

    Rem Nonlinear Types
    Public Const ntNonlinElastic As Int32 = 0
    Public Const ntElastoPlastic As Int32 = 1

    Rem Rubber Types
    Public Const kNeoHookean As Int32 = 1
    Public Const kMooneyRivlin As Int32 = 2
    Public Const kGeneralisedMooneyRivlin As Int32 = 3
    Public Const kOgden As Int32 = 4

    Rem Material Positions
    Public Const ipModulus As Int32 = 0
    Public Const ipPoisson As Int32 = 1
    Public Const ipDensity As Int32 = 2

    Rem Node Result Types - Old convention
    Public Const kNodeDisp As Int32 = 1
    Public Const kNodeVel As Int32 = 2
    Public Const kNodeAcc As Int32 = 3
    Public Const kNodePhase As Int32 = 4
    Public Const kNodeReact As Int32 = 5
    Public Const kNodeTemp As Int32 = 6
    Public Const kNodeFlux As Int32 = 7
    Public Const kNodeInfluence As Int32 = 1

    Rem Node Result Types
    Public Const rtNodeDisp As Int32 = 1
    Public Const rtNodeVel As Int32 = 2
    Public Const rtNodeAcc As Int32 = 3
    Public Const rtNodePhase As Int32 = 4
    Public Const rtNodeReact As Int32 = 5
    Public Const rtNodeTemp As Int32 = 6
    Public Const rtNodeFlux As Int32 = 7
    Public Const rtNodeInfluence As Int32 = 1

    Rem Beam Result Types
    Public Const rtBeamForce As Int32 = 1
    Public Const rtBeamStrain As Int32 = 2
    Public Const rtBeamStress As Int32 = 3
    Public Const rtBeamTRelease As Int32 = 4
    Public Const rtBeamRRelease As Int32 = 5
    Public Const rtBeamCableXYZ As Int32 = 6
    Public Const rtBeamFlux As Int32 = 8
    Public Const rtBeamGradient As Int32 = 9
    Public Const rtBeamCreepStrain As Int32 = 10
    Public Const rtBeamEnergy As Int32 = 11
    Public Const rtBeamDisp As Int32 = 12
    Public Const rtBeamNodeReact As Int32 = 13

    Rem Beam Result Quantities - BEAMFORCE - Local and Principal
    Public Const ipBeamSF1 As Int32 = 0
    Public Const ipBeamBM1 As Int32 = 1
    Public Const ipBeamSF2 As Int32 = 2
    Public Const ipBeamBM2 As Int32 = 3
    Public Const ipBeamAxialF As Int32 = 4
    Public Const ipBeamTorque As Int32 = 5

    Rem Beam Result Quantities - BEAMFORCE - Global
    Public Const ipBeamFX As Int32 = 0
    Public Const ipBeamMX As Int32 = 1
    Public Const ipBeamFY As Int32 = 2
    Public Const ipBeamMY As Int32 = 3
    Public Const ipBeamFZ As Int32 = 4
    Public Const ipBeamMZ As Int32 = 5

    Rem Beam Result Quantities - BEAMSTRESS
    Public Const ipMinFibreStress As Int32 = 0
    Public Const ipMaxFibreStress As Int32 = 1
    Public Const ipMaxShearStress1 As Int32 = 2
    Public Const ipMaxShearStress2 As Int32 = 3
    Public Const ipAvShearStress1 As Int32 = 4
    Public Const ipAvShearStress2 As Int32 = 5
    Public Const ipTorqueStress As Int32 = 6
    Public Const ipMinPrincipalStress As Int32 = 7
    Public Const ipMaxPrincipalStress As Int32 = 8
    Public Const ipMinPipeHoopStress As Int32 = 9
    Public Const ipMaxPipeHoopStress As Int32 = 10
    Public Const ipMinAxialStress As Int32 = 11
    Public Const ipMaxAxialStress As Int32 = 12
    Public Const ipMinBendingStress1 As Int32 = 13
    Public Const ipMaxBendingStress1 As Int32 = 14
    Public Const ipMinBendingStress2 As Int32 = 15
    Public Const ipMaxBendingStress2 As Int32 = 16
    Public Const ipYieldRatio As Int32 = 17

    Rem Beam Result Quantities - BEAMFLUXGRAD
    Public Const ipBeamFlux As Int32 = 0
    Public Const ipBeamTempGradient As Int32 = 1

    Rem Beam Result Quantities - BEAMSTRAIN
    Public Const ipAxialStrain As Int32 = 0
    Public Const ipCurvature1 As Int32 = 1
    Public Const ipCurvature2 As Int32 = 2
    Public Const ipTwist As Int32 = 3

    Rem Beam Result Quantities - BEAMRELEASE
    Public Const ipRelEnd1Dir1 As Int32 = 0
    Public Const ipRelEnd1Dir2 As Int32 = 1
    Public Const ipRelEnd1Dir3 As Int32 = 2
    Public Const ipRelEnd2Dir1 As Int32 = 3
    Public Const ipRelEnd2Dir2 As Int32 = 4
    Public Const ipRelEnd2Dir3 As Int32 = 5

    Rem Beam Result Quantities - BEAMENERGY
    Public Const ipBeamEnergyStored As Int32 = 0
    Public Const ipBeamEnergySpent As Int32 = 1

    Rem Plate Result Types
    Public Const rtPlateStress As Int32 = 1
    Public Const rtPlateStrain As Int32 = 2
    Public Const rtPlateEnergy As Int32 = 3
    Public Const rtPlateForce As Int32 = 4
    Public Const rtPlateMoment As Int32 = 5
    Public Const rtPlateCurvature As Int32 = 6
    Public Const rtPlatePlyStress As Int32 = 7
    Public Const rtPlatePlyStrain As Int32 = 8
    Public Const rtPlatePlyReserve As Int32 = 9
    Public Const rtPlateFlux As Int32 = 10
    Public Const rtPlateGradient As Int32 = 11
    Public Const rtPlateReoDesign As Int32 = 12
    Public Const rtPlateCreepStrain As Int32 = 13
    Public Const rtPlateSoil As Int32 = 14
    Public Const rtPlateUser As Int32 = 15
    Public Const rtPlateNodeReact As Int32 = 16
    Public Const rtPlateNodeDisp As Int32 = 17

    Rem Plate Surface Definition
    Public Const psPlateMidPlane As Int32 = 0
    Public Const psPlateZMinus As Int32 = 1
    Public Const psPlateZPlus As Int32 = 2

    Rem Brick Result Types
    Public Const rtBrickStress As Int32 = 1
    Public Const rtBrickStrain As Int32 = 2
    Public Const rtBrickEnergy As Int32 = 3
    Public Const rtBrickFlux As Int32 = 4
    Public Const rtBrickGradient As Int32 = 5
    Public Const rtBrickCreepStrain As Int32 = 6
    Public Const rtBrickSoil As Int32 = 7
    Public Const rtBrickUser As Int32 = 8
    Public Const rtBrickNodeReact As Int32 = 9
    Public Const rtBrickNodeDisp As Int32 = 10

    Rem Beam Result Sub Types
    Public Const stBeamLocal As Int32 = 0
    Public Const stBeamPrincipal As Int32 = -1
    Public Const stBeamGlobal As Int32 = -2

    Rem Plate Result Sub Types
    Public Const stPlateLocal As Int32 = 0
    Public Const stPlateGlobal As Int32 = -1
    Public Const stPlateCombined As Int32 = -2
    Public Const stPlateSupport As Int32 = -3
    Public Const stPlateDevLocal As Int32 = -4
    Public Const stPlateDevGlobal As Int32 = -5
    Public Const stPlateDevCombined As Int32 = -6

    Rem Brick Result Sub Types
    Public Const stBrickLocal As Int32 = 0
    Public Const stBrickGlobal As Int32 = -1
    Public Const stBrickCombined As Int32 = -2
    Public Const stBrickSupport As Int32 = -3
    Public Const stBrickDevLocal As Int32 = -4
    Public Const stBrickDevGlobal As Int32 = -5
    Public Const stBrickDevCombined As Int32 = -6

    Rem Plate/Brick Result Sub Types (Undocumented)
    Public Const stLOCAL As Int32 = 0
    Public Const stGLOBAL As Int32 = 1
    Public Const stUCS As Int32 = 2
    Public Const stCOMBINED As Int32 = 3

    Rem PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEMOMENT, PLATECURVATURE, PLATEFORCE results for STLOCAL
    Public Const ipPlateLocalxx As Int32 = 0
    Public Const ipPlateLocalyy As Int32 = 1
    Public Const ipPlateLocalzz As Int32 = 2
    Public Const ipPlateLocalxy As Int32 = 3
    Public Const ipPlateLocalyz As Int32 = 4
    Public Const ipPlateLocalzx As Int32 = 5
    Public Const ipPlateLocalxz As Int32 = 5
    Public Const ipPlateLocalMean As Int32 = 0
    Public Const ipPlateLocalDevxx As Int32 = 1
    Public Const ipPlateLocalDevyy As Int32 = 2
    Public Const ipPlateEdgeSupport As Int32 = 0
    Public Const ipPlateFaceSupport As Int32 = 1

    Rem PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEMOMENT, PLATECURVATURE, PLATEFORCE results for STGLOBAL (NOT AXISYMMETRIC)
    Public Const ipPlateGlobalXX As Int32 = 0
    Public Const ipPlateGlobalYY As Int32 = 1
    Public Const ipPlateGlobalZZ As Int32 = 2
    Public Const ipPlateGlobalXY As Int32 = 3
    Public Const ipPlateGlobalYZ As Int32 = 4
    Public Const ipPlateGlobalZX As Int32 = 5
    Public Const ipPlateGlobalMean As Int32 = 0
    Public Const ipPlateGlobalDevXX As Int32 = 1
    Public Const ipPlateGlobalDevYY As Int32 = 2
    Public Const ipPlateGlobalDevZZ As Int32 = 3

    Rem PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEMOMENT, PLATECURVATURE, PLATEFORCE results for STUCS
    Public Const ipPlateUCSXX As Int32 = 0
    Public Const ipPlateUCSYY As Int32 = 1
    Public Const ipPlateUCSZZ As Int32 = 2
    Public Const ipPlateUCSXY As Int32 = 3
    Public Const ipPlateUCSYZ As Int32 = 4
    Public Const ipPlateUCSZX As Int32 = 5

    Rem PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEFORCE, PLATEMOMENT, PLATECURVATURE results for STCOMBINED (NOT AXISYMMETRIC)
    Public Const ipPlateCombPrincipal11 As Int32 = 0
    Public Const ipPlateCombPrincipal22 As Int32 = 1
    Public Const ipPlateCombPrincipalAngle As Int32 = 3
    Public Const ipPlateCombVonMises As Int32 = 4
    Public Const ipPlateCombTresca As Int32 = 5
    Public Const ipPlateCombMohrCoulomb As Int32 = 6
    Public Const ipPlateCombDruckerPrager As Int32 = 7
    Public Const ipPlateCombPlasticStrain As Int32 = 6
    Public Const ipPlateCombCreepEffRate As Int32 = 6
    Public Const ipPlateCombCreepShrinkage As Int32 = 7
    Public Const ipPlateCombYieldIndex As Int32 = 8
    Public Const ipPlateCombMean As Int32 = 0
    Public Const ipPlateCombDev11 As Int32 = 1
    Public Const ipPlateCombDev22 As Int32 = 2

    Rem PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN results for STGLOBAL (AXISYMMETRIC)
    Public Const ipPlateAxiGlobalRR As Int32 = 0
    Public Const ipPlateAxiGlobalZZ As Int32 = 1
    Public Const ipPlateAxiGlobalTT As Int32 = 2
    Public Const ipPlateAxiGlobalRZ As Int32 = 3
    Public Const ipPlateAxiGlobalMean As Int32 = 0
    Public Const ipPlateAxiGlobalDevRR As Int32 = 1
    Public Const ipPlateAxiGlobalDevZZ As Int32 = 2
    Public Const ipPlateAxiGlobalDevTT As Int32 = 3

    Rem PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN results for STCOMBINED (AXISYMMETRIC)
    Public Const ipPlateAxiCombPrincipal11 As Int32 = 0
    Public Const ipPlateAxiCombPrincipal22 As Int32 = 1
    Public Const ipPlateAxiCombPrincipal33 As Int32 = 2
    Public Const ipPlateAxiCombVonMises As Int32 = 4
    Public Const ipPlateAxiCombTresca As Int32 = 5
    Public Const ipPlateAxiCombMohrCoulomb As Int32 = 6
    Public Const ipPlateAxiCombDruckerPrager As Int32 = 7
    Public Const ipPlateAxiCombPlasticStrain As Int32 = 6
    Public Const ipPlateAxiCombCreepEffRate As Int32 = 5
    Public Const ipPlateAxiCombCreepShrinkage As Int32 = 7
    Public Const ipPlateAxiCombYieldIndex As Int32 = 8
    Public Const ipPlateAxiCombMean As Int32 = 0
    Public Const ipPlateAxiCombDev11 As Int32 = 1
    Public Const ipPlateAxiCombDev22 As Int32 = 2
    Public Const ipPlateAxiCombDev33 As Int32 = 3

    Rem PLATEPLYSTRESS
    Public Const ipPlyStress11 As Int32 = 0
    Public Const ipPlyStress22 As Int32 = 1
    Public Const ipPlyStress12 As Int32 = 3
    Public Const ipPlyILSx As Int32 = 4
    Public Const ipPlyILSy As Int32 = 5

    Rem PLATEPLYSTRAIN
    Public Const ipPlyStrain11 As Int32 = 0
    Public Const ipPlyStrain22 As Int32 = 1
    Public Const ipPlyStrain12 As Int32 = 3

    Rem PLATEPLYRESERVE
    Public Const ipPlyMaxStress As Int32 = 0
    Public Const ipPlyMaxStrain As Int32 = 1
    Public Const ipPlyTsaiHill As Int32 = 2
    Public Const ipPlyModTsaiWu As Int32 = 3
    Public Const ipPlyHoffman As Int32 = 4
    Public Const ipPlyInterlam As Int32 = 5

    Rem PLATESOIL
    Public Const ipPlateSoilTotalPorePressure As Int32 = 0
    Public Const ipPlateSoilExcessPorePressure As Int32 = 1
    Public Const ipPlateSoilOCRIndex As Int32 = 2
    Public Const ipPlateSoilStateIndex As Int32 = 3
    Public Const ipPlateSoilVoidRatio As Int32 = 4

    Rem PLATEFLUX, PLATEGRADIENT results for STLOCAL
    Public Const ipPlateFluxLocalx As Int32 = 0
    Public Const ipPlateFluxLocaly As Int32 = 1
    Public Const ipPlateFluxLocalxy As Int32 = 2

    Rem PLATEFLUX, PLATEGRADIENT results for STGLOBAL
    Public Const ipPlateFluxGlobalX As Int32 = 0
    Public Const ipPlateFluxGlobalY As Int32 = 1
    Public Const ipPlateFluxGlobalZ As Int32 = 2
    Public Const ipPlateFluxGlobalXY As Int32 = 3
    Public Const ipPlateFluxGlobalYZ As Int32 = 4
    Public Const ipPlateFluxGlobalZX As Int32 = 5
    Public Const ipPlateFluxGlobalSRSS As Int32 = 6

    Rem PLATEFLUX, PLATEGRADIENT results for STUCS
    Public Const ipPlateFluxUCSX As Int32 = 0
    Public Const ipPlateFluxUCSY As Int32 = 1
    Public Const ipPlateFluxUCSZ As Int32 = 2
    Public Const ipPlateFluxUCSXY As Int32 = 3
    Public Const ipPlateFluxUCSYZ As Int32 = 4
    Public Const ipPlateFluxUCSZX As Int32 = 5
    Public Const ipPlateFluxUCSSRSS As Int32 = 6

    Rem PLATEREODESIGN
    Public Const ipPlateRCWoodArmerMoment As Int32 = 0
    Public Const ipPlateRCWoodArmerForce As Int32 = 1
    Public Const ipPlateRCSteelArea As Int32 = 2
    Public Const ipPlateRCSteelAreaLessBase As Int32 = 3
    Public Const ipPlateRCSteelStress As Int32 = 4
    Public Const ipPlateRCConcreteStrain As Int32 = 5
    Public Const ipPlateRCBlockRatio As Int32 = 6

    Rem PLATENODEREACT
    Public Const ipPlateNodeReactFX As Int32 = 0
    Public Const ipPlateNodeReactFY As Int32 = 1
    Public Const ipPlateNodeReactFZ As Int32 = 2
    Public Const ipPlateNodeReactMX As Int32 = 3
    Public Const ipPlateNodeReactMY As Int32 = 4
    Public Const ipPlateNodeReactMZ As Int32 = 5

    Rem PLATEENERGY
    Public Const ipPlateEnergyStored As Int32 = 0
    Public Const ipPlateEnergySpent As Int32 = 1

    Rem BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STLOCAL
    Public Const ipBrickLocalxx As Int32 = 0
    Public Const ipBrickLocalyy As Int32 = 1
    Public Const ipBrickLocalzz As Int32 = 2
    Public Const ipBrickLocalxy As Int32 = 3
    Public Const ipBrickLocalyz As Int32 = 4
    Public Const ipBrickLocalzx As Int32 = 5
    Public Const ipBrickLocalMean As Int32 = 0
    Public Const ipBrickLocalDevxx As Int32 = 1
    Public Const ipBrickLocalDevyy As Int32 = 2
    Public Const ipBrickLocalDevzz As Int32 = 3
    Public Const ipBrickFaceSupport As Int32 = 0

    Rem BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STGLOBAL
    Public Const ipBrickGlobalXX As Int32 = 0
    Public Const ipBrickGlobalYY As Int32 = 1
    Public Const ipBrickGlobalZZ As Int32 = 2
    Public Const ipBrickGlobalXY As Int32 = 3
    Public Const ipBrickGlobalYZ As Int32 = 4
    Public Const ipBrickGlobalZX As Int32 = 5
    Public Const ipBrickGlobalMean As Int32 = 0
    Public Const ipBrickGlobalDevXX As Int32 = 1
    Public Const ipBrickGlobalDevYY As Int32 = 2
    Public Const ipBrickGlobalDevZZ As Int32 = 3

    Rem BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STUCS
    Public Const ipBrickUCSXX As Int32 = 0
    Public Const ipBrickUCSYY As Int32 = 1
    Public Const ipBrickUCSZZ As Int32 = 2
    Public Const ipBrickUCSXY As Int32 = 3
    Public Const ipBrickUCSYZ As Int32 = 4
    Public Const ipBrickUCSZX As Int32 = 5

    Rem BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STCOMBINED
    Public Const ipBrickCombPrincipal11 As Int32 = 0
    Public Const ipBrickCombPrincipal22 As Int32 = 1
    Public Const ipBrickCombPrincipal33 As Int32 = 2
    Public Const ipBrickCombVonMises As Int32 = 3
    Public Const ipBrickCombTresca As Int32 = 4
    Public Const ipBrickCombMohrCoulomb As Int32 = 5
    Public Const ipBrickCombDruckerPrager As Int32 = 6
    Public Const ipBrickCombPlasticStrain As Int32 = 6
    Public Const ipBrickCombCreepEffRate As Int32 = 6
    Public Const ipBrickCombCreepShrinkage As Int32 = 7
    Public Const ipBrickCombYieldIndex As Int32 = 8
    Public Const ipBrickCombMean As Int32 = 0
    Public Const ipBrickCombDev11 As Int32 = 1
    Public Const ipBrickCombDev22 As Int32 = 2
    Public Const ipBrickCombDev33 As Int32 = 3

    Rem BRICKSOIL
    Public Const ipBrickSoilTotalPorePressure As Int32 = 0
    Public Const ipBrickSoilExcessPorePressure As Int32 = 1
    Public Const ipBrickSoilOCRIndex As Int32 = 2
    Public Const ipBrickSoilStateIndex As Int32 = 3
    Public Const ipBrickSoilVoidRatio As Int32 = 4

    Rem BRICKFLUX, BRICKGRADIENT results for STLOCAL
    Public Const ipBrickFluxLocalx As Int32 = 0
    Public Const ipBrickFluxLocaly As Int32 = 1
    Public Const ipBrickFluxLocalz As Int32 = 2
    Public Const ipBrickFluxLocalxy As Int32 = 3
    Public Const ipBrickFluxLocalyz As Int32 = 4
    Public Const ipBrickFluxLocalzx As Int32 = 5
    Public Const ipBrickFluxLocalRMS As Int32 = 6

    Rem BRICKFLUX, BRICKGRADIENT results for STGLOBAL
    Public Const ipBrickFluxGlobalX As Int32 = 0
    Public Const ipBrickFluxGlobalY As Int32 = 1
    Public Const ipBrickFluxGlobalZ As Int32 = 2
    Public Const ipBrickFluxGlobalXY As Int32 = 3
    Public Const ipBrickFluxGlobalYZ As Int32 = 4
    Public Const ipBrickFluxGlobalZX As Int32 = 5
    Public Const ipBrickFluxGlobalRMS As Int32 = 6

    Rem BRICKFLUX, BRICKGRADIENT results for STUCS
    Public Const ipBrickFluxUCSX As Int32 = 0
    Public Const ipBrickFluxUCSY As Int32 = 1
    Public Const ipBrickFluxUCSZ As Int32 = 2
    Public Const ipBrickFluxUCSXY As Int32 = 3
    Public Const ipBrickFluxUCSYZ As Int32 = 4
    Public Const ipBrickFluxUCSZX As Int32 = 5
    Public Const ipBrickFluxUCSRMS As Int32 = 6

    Rem BRICKNODEREACT
    Public Const ipBrickNodeReactFX As Int32 = 0
    Public Const ipBrickNodeReactFY As Int32 = 1
    Public Const ipBrickNodeReactFZ As Int32 = 2

    Rem BRICKENERGY
    Public Const ipBrickEnergyStored As Int32 = 0
    Public Const ipBrickEnergySpent As Int32 = 1

    Rem MODAL RESULTS NFA
    Public Const ipFrequencyNFA As Int32 = 0
    Public Const ipModalMassNFA As Int32 = 1
    Public Const ipModalStiffNFA As Int32 = 2
    Public Const ipModalDampNFA As Int32 = 3
    Public Const ipModalTMassP1 As Int32 = 4
    Public Const ipModalTMassP2 As Int32 = 5
    Public Const ipModalTMassP3 As Int32 = 6
    Public Const ipModalRMassP1 As Int32 = 7
    Public Const ipModalRMassP2 As Int32 = 8
    Public Const ipModalRMassP3 As Int32 = 9

    Rem INERTIA RELIEF RESULTS
    Public Const ipMassXIRA As Int32 = 0
    Public Const ipMassYIRA As Int32 = 1
    Public Const ipMassZIRA As Int32 = 2
    Public Const ipXcIRA As Int32 = 3
    Public Const ipYcIRA As Int32 = 4
    Public Const ipZcIRA As Int32 = 5
    Public Const ipAccXIRA As Int32 = 6
    Public Const ipAccYIRA As Int32 = 7
    Public Const ipAccZIRA As Int32 = 8
    Public Const ipAngAccXIRA As Int32 = 9
    Public Const ipAngAccYIRA As Int32 = 10
    Public Const ipAngAccZIRA As Int32 = 11

    Rem UCS Types
    Public Const UCSCartesian As Int32 = 0
    Public Const UCSCylindrical As Int32 = 1
    Public Const UCSSpherical As Int32 = 2
    Public Const UCSToroidal As Int32 = 3

    Rem Matrix Types
    Public Const mtCompliance As Int32 = 1
    Public Const mtStiffness As Int32 = 2

    Rem Node/Vertex Attribute Types
    Public Const ATTRFreedom As Int32 = 1
    Public Const ATTRForce As Int32 = 2
    Public Const ATTRMoment As Int32 = 3
    Public Const ATTRTemperature As Int32 = 4
    Public Const ATTRMTranslation As Int32 = 5
    Public Const ATTRMRotation As Int32 = 6
    Public Const ATTRKTranslation As Int32 = 7
    Public Const ATTRKRotation As Int32 = 8
    Public Const ATTRDamping As Int32 = 9
    Public Const ATTRNSMass As Int32 = 10
    Public Const ATTRNodeInfluence As Int32 = 11
    Public Const ATTRNodeHeatSource As Int32 = 12
    Public Const ATTRNodeVelocity As Int32 = 13
    Public Const ATTRNodeAcceleration As Int32 = 14

    Rem Vertex Types
    Public Const vtFree As Int32 = 1
    Public Const vtFixed As Int32 = 2

    Rem Beam Attribute Types
    Public Const ATTRBeamAngle As Int32 = 21
    Public Const ATTRBeamOffset As Int32 = 22
    Public Const ATTRBeamTEndRelease As Int32 = 23
    Public Const ATTRBeamREndRelease As Int32 = 24
    Public Const ATTRBeamSupport As Int32 = 25
    Public Const ATTRBeamPreTension As Int32 = 26
    Public Const ATTRCableFreeLength As Int32 = 27
    Public Const ATTRBeamDLL As Int32 = 28
    Public Const ATTRBeamDLG As Int32 = 29
    Public Const ATTRBeamCFL As Int32 = 30
    Public Const ATTRBeamCFG As Int32 = 31
    Public Const ATTRBeamCML As Int32 = 32
    Public Const ATTRBeamCMG As Int32 = 33
    Public Const ATTRBeamTempGradient As Int32 = 34
    Public Const ATTRBeamConvection As Int32 = 35
    Public Const ATTRBeamRadiation As Int32 = 36
    Public Const ATTRBeamFlux As Int32 = 37
    Public Const ATTRBeamHeatSource As Int32 = 38
    Public Const ATTRBeamRadius As Int32 = 39
    Public Const ATTRPipePressure As Int32 = 40
    Public Const ATTRBeamNSMass As Int32 = 41
    Public Const ATTRPipeTemperature As Int32 = 42
    Public Const ATTRBeamDML As Int32 = 44
    Public Const ATTRBeamStringGroup As Int32 = 45
    Public Const ATTRBeamTaper As Int32 = 92
    Public Const ATTRBeamInfluence As Int32 = 93
    Public Const ATTRBeamSectionFactor As Int32 = 94
    Public Const ATTRBeamCreepLoadingAge As Int32 = 95
    Public Const ATTRBeamEndAttachment As Int32 = 96
    Public Const ATTRBeamConnectionUCS As Int32 = 97
    Public Const ATTRBeamStageProperty As Int32 = 98

    Rem Plate/Edge/Face Attribute Types
    Public Const ATTRPlateAngle As Int32 = 51
    Public Const ATTRPlateOffset As Int32 = 52
    Public Const ATTRPlatePreLoad As Int32 = 53
    Public Const ATTRPlateFacePressure As Int32 = 54
    Public Const ATTRPlateFaceShear As Int32 = 55
    Public Const ATTRPlateEdgePressure As Int32 = 56
    Public Const ATTRPlateEdgeShear As Int32 = 57
    Public Const ATTRPlateEdgeNormalShear As Int32 = 58
    Public Const ATTRPlateTempGradient As Int32 = 59
    Public Const ATTRPlateEdgeSupport As Int32 = 60
    Public Const ATTRPlateFaceSupport As Int32 = 61
    Public Const ATTRPlateEdgeConvection As Int32 = 62
    Public Const ATTRPlateEdgeRadiation As Int32 = 63
    Public Const ATTRPlateFlux As Int32 = 64
    Public Const ATTRPlateHeatSource As Int32 = 65
    Public Const ATTRPlateGlobalPressure As Int32 = 66
    Public Const ATTRPlateEdgeRelease As Int32 = 67
    Public Const ATTRPlateThickness As Int32 = 69
    Public Const ATTRPlateNSMass As Int32 = 70
    Public Const ATTRLoadPatch As Int32 = 71
    Public Const ATTRPlatePointForce As Int32 = 99
    Public Const ATTRPlatePointMoment As Int32 = 100
    Public Const ATTRPlateFaceConvection As Int32 = 101
    Public Const ATTRPlateFaceRadiation As Int32 = 102
    Public Const ATTRPlateInfluence As Int32 = 103
    Public Const ATTRPlateSoilStress As Int32 = 104
    Public Const ATTRPlateSoilRatio As Int32 = 105
    Public Const ATTRPlateCreepLoadingAge As Int32 = 106
    Public Const ATTRPlateEdgeAttachment As Int32 = 107
    Public Const ATTRPlateFaceAttachment As Int32 = 108
    Public Const ATTRPlateStageProperty As Int32 = 109

    Rem Edge Types
    Public Const etInterpolated As Int32 = 0
    Public Const etNonInterpolated As Int32 = 1

    Rem Plate/Face Global Pressure Projection Options
    Public Const pfNone As Int32 = 0
    Public Const pfProjResultant As Int32 = 1
    Public Const pfProjComponents As Int32 = 2

    Rem Brick Attribute Types
    Public Const ATTRBrickPressure As Int32 = 81
    Public Const ATTRBrickShear As Int32 = 82
    Public Const ATTRBrickFaceFoundation As Int32 = 83
    Public Const ATTRBrickConvection As Int32 = 84
    Public Const ATTRBrickRadiation As Int32 = 85
    Public Const ATTRBrickFlux As Int32 = 86
    Public Const ATTRBrickHeatSource As Int32 = 87
    Public Const ATTRBrickGlobalPressure As Int32 = 88
    Public Const ATTRBrickNSMass As Int32 = 89
    Public Const ATTRBrickLocalAxes As Int32 = 90
    Public Const ATTRBrickPreLoad As Int32 = 91
    Public Const ATTRBrickPointForce As Int32 = 110
    Public Const ATTRBrickInfluence As Int32 = 111
    Public Const ATTRBrickSoilStress As Int32 = 112
    Public Const ATTRBrickSoilRatio As Int32 = 113
    Public Const ATTRBrickCreepLoadingAge As Int32 = 114
    Public Const ATTRBrickFaceAttachment As Int32 = 115
    Public Const ATTRBrickStageProperty As Int32 = 116

    Rem Titles
    Public Const TITLEModel As Int32 = 0
    Public Const TITLEProject As Int32 = 1
    Public Const TITLEReference As Int32 = 2
    Public Const TITLEAuthor As Int32 = 3
    Public Const TITLECreated As Int32 = 4
    Public Const TITLEModified As Int32 = 5

    Rem Table Types
    Public Const ttVsTime As Int32 = 1
    Public Const ttVsTemperature As Int32 = 2
    Public Const ttVsFrequency As Int32 = 3
    Public Const ttStressStrain As Int32 = 4
    Public Const ttForceDisplacement As Int32 = 5
    Public Const ttMomentCurvature As Int32 = 6
    Public Const ttMomentRotation As Int32 = 8
    Public Const ttAccVsTime As Int32 = 9
    Public Const ttForceVelocity As Int32 = 10
    Public Const ttVsPosition As Int32 = 11
    Public Const ttStrainTime As Int32 = 12

    Rem Frequency Table Types
    Public Const tyPeriod As Int32 = 0
    Public Const tyFrequency As Int32 = 1

    Rem Beam Prop Table Entries
    Public Const ptBeamStiffModVsTemp As Int32 = 1001
    Public Const ptBeamAlphaVsTemp As Int32 = 1002
    Public Const ptBeamConductVsTemp As Int32 = 1003
    Public Const ptBeamCpVsTemp As Int32 = 1004
    Public Const ptBeamStiffModVsTime As Int32 = 1005
    Public Const ptBeamConductVsTime As Int32 = 1006
    Public Const ptSpringAxialVsDisp As Int32 = 1007
    Public Const ptSpringTorqueVsTwist As Int32 = 1008
    Public Const ptSpringAxialVsVelocity As Int32 = 1009
    Public Const ptTrussAxialStressVsStrain As Int32 = 1010
    Public Const ptBeamAxialStressVsStrain As Int32 = 1011
    Public Const ptBeamMomentK1 As Int32 = 1012
    Public Const ptBeamMomentK2 As Int32 = 1013
    Public Const ptConnectionShear1 As Int32 = 1014
    Public Const ptConnectionShear2 As Int32 = 1015
    Public Const ptConnectionAxial As Int32 = 1016
    Public Const ptConnectionBend1 As Int32 = 1017
    Public Const ptConnectionBend2 As Int32 = 1018
    Public Const ptConnectionTorque As Int32 = 1019
    Public Const ptBeamYieldVsTemp As Int32 = 1020

    Rem Plate Prop Table Entries
    Public Const ptPlateModVsTemp As Int32 = 2001
    Public Const ptPlateAlphaVsTemp As Int32 = 2002
    Public Const ptPlateConductVsTemp As Int32 = 2003
    Public Const ptPlateCpVsTemp As Int32 = 2004
    Public Const ptPlateModVsTime As Int32 = 2005
    Public Const ptPlateConductVsTime As Int32 = 2006
    Public Const ptPlateStressVsStrain As Int32 = 2007
    Public Const ptPlateYieldVsTemp As Int32 = 2008

    Rem Brick Prop Table Entries
    Public Const ptBrickModVsTemp As Int32 = 3001
    Public Const ptBrickAlphaVsTemp As Int32 = 3002
    Public Const ptBrickConductVsTemp As Int32 = 3003
    Public Const ptBrickCpVsTemp As Int32 = 3004
    Public Const ptBrickModVsTime As Int32 = 3005
    Public Const ptBrickConductVsTime As Int32 = 3006
    Public Const ptBrickStressVsStrain As Int32 = 3007
    Public Const ptBrickYieldVsTemp As Int32 = 3008

    Rem Creep Laws
    Public Const clConcreteHyperbolic As Int32 = 0
    Public Const clConcreteViscoChain As Int32 = 1
    Public Const clConcreteUserDefined As Int32 = 2
    Public Const clPrimaryPower As Int32 = 3
    Public Const clSecondaryPower As Int32 = 4
    Public Const clPrimarySecondaryPower As Int32 = 5
    Public Const clSecondaryHyperbolic As Int32 = 6
    Public Const clSecondaryExponential As Int32 = 7
    Public Const clThetaProjection As Int32 = 8
    Public Const clGenGraham As Int32 = 9
    Public Const clGenBlackburn As Int32 = 10
    Public Const clUserDefined As Int32 = 11

    Rem Load Case Types
    Public Const kNoInertia As Int32 = 0
    Public Const kGravity As Int32 = 1
    Public Const kAccelerations As Int32 = 2

    Rem Freedom Case Types
    Public Const kNormalFreedom As Int32 = 0
    Public Const kFreeBodyInertiaRelief As Int32 = 1
    Public Const kSingleSymmetryInertiaXY As Int32 = 2
    Public Const kSingleSymmetryInertiaYZ As Int32 = 3
    Public Const kSingleSymmetryInertiaZX As Int32 = 4
    Public Const kDoubleSymmetryInertiaX As Int32 = 5
    Public Const kDoubleSymmetryInertiaY As Int32 = 6
    Public Const kDoubleSymmetryInertiaZ As Int32 = 7

    Rem Global Load and Freedom Cases
    Public Const ipRefTemp As Int32 = 0
    Public Const ipGlobOrigX As Int32 = 1
    Public Const ipGlobOrigY As Int32 = 2
    Public Const ipGlobOrigZ As Int32 = 3
    Public Const ipGlobAccX As Int32 = 4
    Public Const ipGlobAccY As Int32 = 5
    Public Const ipGlobAccZ As Int32 = 6
    Public Const ipGlobAngVelX As Int32 = 7
    Public Const ipGlobAngVelY As Int32 = 8
    Public Const ipGlobAngVelZ As Int32 = 9
    Public Const ipGlobAngAccX As Int32 = 10
    Public Const ipGlobAngAccY As Int32 = 11
    Public Const ipGlobAngAccZ As Int32 = 12

    Rem Damping Types
    Public Const dtNoDamping As Int32 = 0
    Public Const dtRayleighDamping As Int32 = 1
    Public Const dtModalDamping As Int32 = 2
    Public Const dtViscousDamping As Int32 = 3

    Rem Rayleigh Modes
    Public Const rmSetFrequencies As Int32 = 0
    Public Const rmSetAlphaBeta As Int32 = 1

    Rem Entity Solver Result Types - HEAT
    Public Const hrNodeFlux As Int32 = 1
    Public Const hrBeamFlux As Int32 = 2
    Public Const hrPlateFlux As Int32 = 3
    Public Const hrBrickFlux As Int32 = 4

    Rem Entity Solver Result Types - FREQUENCY
    Public Const frBeamForcePattern As Int32 = 5
    Public Const frBeamStrainPattern As Int32 = 6
    Public Const frPlateStressPattern As Int32 = 7
    Public Const frPlateStrainPattern As Int32 = 8
    Public Const frBrickStressPattern As Int32 = 9
    Public Const frBrickStrainPattern As Int32 = 10

    Rem Entity Solver Result Types - STRUCTURAL
    Public Const srNodeReaction As Int32 = 11
    Public Const srNodeVelocity As Int32 = 12
    Public Const srNodeAcceleration As Int32 = 13
    Public Const srBeamForce As Int32 = 14
    Public Const srBeamMNLStress As Int32 = 15
    Public Const srBeamStrain As Int32 = 16
    Public Const srPlateStress As Int32 = 17
    Public Const srPlateStrain As Int32 = 18
    Public Const srBrickStress As Int32 = 19
    Public Const srBrickStrain As Int32 = 20
    Public Const srElementNodeForce As Int32 = 21

    Rem Solver Defaults - LOGICALS
    Public Const spDoSturm As Int32 = 1
    Public Const spNonlinearMaterial As Int32 = 2
    Public Const spNonlinearGeometry As Int32 = 4
    Public Const spAddKg As Int32 = 6
    Public Const spCalcDampingRatios As Int32 = 8
    Public Const spIncludeLinkReactions As Int32 = 9
    Public Const spFullSystemTransient As Int32 = 10
    Public Const spNonlinearHeat As Int32 = 11
    Public Const spLumpedLoadBeam As Int32 = 12
    Public Const spLumpedLoadPlate As Int32 = 13
    Public Const spLumpedLoadBrick As Int32 = 14
    Public Const spLumpedMassBeam As Int32 = 15
    Public Const spLumpedMassPlate As Int32 = 16
    Public Const spLumpedMassBrick As Int32 = 17
    Public Const spForceDrillCheck As Int32 = 18
    Public Const spSaveRestartFile As Int32 = 20
    Public Const spSaveIntermediate As Int32 = 21
    Public Const spExcludeMassX As Int32 = 22
    Public Const spExcludeMassY As Int32 = 23
    Public Const spExcludeMassZ As Int32 = 24
    Public Const spSaveSRSSSpectral As Int32 = 25
    Public Const spSaveCQCSpectral As Int32 = 26
    Public Const spDoResidualsCheck As Int32 = 27
    Public Const spSuppressAllSingularities As Int32 = 28
    Public Const spSaveModalResults As Int32 = 29
    Public Const spSpectralReactionAsInertia As Int32 = 30
    Public Const spReducedLogFile As Int32 = 31
    Public Const spIncludeRotationalMass As Int32 = 32
    Public Const spIgnoreCompressiveBeamKg As Int32 = 33
    Public Const spAutoScaleKg As Int32 = 34
    Public Const spScaleSupports As Int32 = 36
    Public Const spAutoShift As Int32 = 37
    Public Const spSaveTableInsertedSteps As Int32 = 38
    Public Const spSaveLastRestartStep As Int32 = 39
    Public Const spAutoAssignPathDivisions As Int32 = 40
    Public Const spDoInstantNTA As Int32 = 41
    Public Const spAllowExtraIterations As Int32 = 42
    Public Const spPredictImpact As Int32 = 43

    Rem Solver Defaults - INTEGERS
    Public Const spTreeStartNumber As Int32 = 1
    Public Const spNumFrequency As Int32 = 2
    Public Const spNumBucklingModes As Int32 = 3
    Public Const spMaxIterationEig As Int32 = 4
    Public Const spMaxIterationNonlin As Int32 = 5
    Public Const spNumBeamSlicesSpectral As Int32 = 6
    Public Const spMaxConjugateGradientIter As Int32 = 7
    Public Const spMaxNumWarnings As Int32 = 8
    Public Const spFiniteStrainDefinition As Int32 = 9
    Public Const spBeamLength As Int32 = 10
    Public Const spFormStiffMatrix As Int32 = 11
    Public Const spMaxUpdateInterval As Int32 = 12
    Public Const spFormNonlinHeatStiffMatrix As Int32 = 13
    Public Const spExpandWorkingSet As Int32 = 14
    Public Const spMinNumViscoUnits As Int32 = 15
    Public Const spMaxNumViscoUnits As Int32 = 16
    Public Const spCurveFitTimeUnit As Int32 = 17
    Public Const spStaticAutoStepping As Int32 = 18
    Public Const spBeamKgType As Int32 = 19
    Public Const spDynamicAutoStepping As Int32 = 20

    Rem Solver Defaults - DOUBLES
    Public Const spEigenTolerance As Int32 = 1
    Public Const spFrequencyShift As Int32 = 2
    Public Const spBucklingShift As Int32 = 3
    Public Const spNonlinDispTolerance As Int32 = 4
    Public Const spNonlinResidualTolerance As Int32 = 5
    Public Const spTransientReferenceTemperature As Int32 = 6
    Public Const spRelaxationFactor As Int32 = 7
    Public Const spNonlinHeatTolerance As Int32 = 8
    Public Const spMinimumTimeStep As Int32 = 9
    Public Const spWilsonTheta As Int32 = 10
    Public Const spNewmarkBeta As Int32 = 11
    Public Const spGlobalZeroDiagonal As Int32 = 12
    Public Const spConjugateGradientTol As Int32 = 13
    Public Const spMinimumDimension As Int32 = 14
    Public Const spMinimumInternalAngle As Int32 = 15
    Public Const spZeroForce As Int32 = 16
    Public Const spZeroDiagonal As Int32 = 17
    Public Const spZeroContactFactor As Int32 = 18
    Public Const spFrictionCutoffStrain As Int32 = 19
    Public Const spZeroTranslation As Int32 = 20
    Public Const spZeroRotation As Int32 = 21
    Public Const spDrillStiffFactor As Int32 = 22
    Public Const spMaxNormalsAngle As Int32 = 24
    Public Const spMaximumRotation As Int32 = 26
    Public Const spZeroDisplacement As Int32 = 27
    Public Const spMaximumDispRatio As Int32 = 28
    Public Const spMinimumLoadReductionFactor As Int32 = 29
    Public Const spMaxDispChange As Int32 = 30
    Public Const spMaxResidualChange As Int32 = 31
    Public Const spZeroFrequency As Int32 = 32
    Public Const spZeroBucklingEigen As Int32 = 33
    Public Const spCurveFitTime As Int32 = 34
    Public Const spSpacingBias As Int32 = 35
    Public Const spTimeStepParam As Int32 = 36
    Public Const spSlidingFrictionFactor As Int32 = 37
    Public Const spMNLTangentRatio As Int32 = 38
    Public Const spStickingFrictionFactor As Int32 = 39
    Public Const spMinArcLengthFactor As Int32 = 40
    Public Const spMaxFibreStrainInc As Int32 = 41

    Rem Modal Load Types
    Public Const mtBaseAcc As Int32 = 0
    Public Const mtBaseVel As Int32 = 1
    Public Const mtBaseDisp As Int32 = 2
    Public Const mtAppliedLoad As Int32 = 3

    Rem Solver Types
    Public Const stSkyline As Int32 = 0
    Public Const stSparse As Int32 = 1
    Public Const stIterativePCG As Int32 = 3

    Rem Solver Temperature Types
    Public Const tdNone As Int32 = 0
    Public Const tdCombined As Int32 = 1

    Rem Harmonic Load Types
    Public Const htVsFrequency As Int32 = 0
    Public Const htVsTime As Int32 = 1

    Rem Sort Types
    Public Const rnNone As Int32 = 0
    Public Const rnTree As Int32 = 1
    Public Const rnGeometry As Int32 = 2
    Public Const rnAMD As Int32 = 3

    Rem Utility
    Public Const ztAbsolute As Int32 = 0
    Public Const ztRelative As Int32 = 1

    Rem Boolean Types
    Public Const btFalse As Int32 = 0
    Public Const btTrue As Int32 = 1

    Rem Error Codes
    Public Const ERR7_InvalidRegionalSettings As Int32 = -6
    Public Const ERR7_InvalidDLLsPresent As Int32 = -5
    Public Const ERR7_APINotInitialised As Int32 = -4
    Public Const ERR7_InvalidErrorCode As Int32 = -3
    Public Const ERR7_APINotLicensed As Int32 = -2
    Public Const ERR7_UnknownError As Int32 = -1
    Public Const ERR7_NoError As Int32 = 0
    Public Const ERR7_FileAlreadyOpen As Int32 = 1
    Public Const ERR7_FileNotFound As Int32 = 2
    Public Const ERR7_FileNotSt7 As Int32 = 3
    Public Const ERR7_InvalidFileName As Int32 = 4
    Public Const ERR7_FileIsNewer As Int32 = 5
    Public Const ERR7_CannotReadFile As Int32 = 6
    Public Const ERR7_InvalidScratchPath As Int32 = 7
    Public Const ERR7_FileNotOpen As Int32 = 8
    Public Const ERR7_ExceededTotal As Int32 = 9
    Public Const ERR7_DataNotFound As Int32 = 10
    Public Const ERR7_InvalidResultFile As Int32 = 11
    Public Const ERR7_ResultFileNotOpen As Int32 = 12
    Public Const ERR7_ExceededResultCase As Int32 = 13
    Public Const ERR7_UnknownResultType As Int32 = 14
    Public Const ERR7_UnknownResultLocation As Int32 = 15
    Public Const ERR7_UnknownSurfaceLocation As Int32 = 16
    Public Const ERR7_UnknownProperty As Int32 = 17
    Public Const ERR7_InvalidEntity As Int32 = 18
    Public Const ERR7_InvalidBeamPosition As Int32 = 19
    Public Const ERR7_InvalidLoadCase As Int32 = 20
    Public Const ERR7_InvalidFreedomCase As Int32 = 21
    Public Const ERR7_UnknownTitle As Int32 = 22
    Public Const ERR7_UnknownUCS As Int32 = 23
    Public Const ERR7_TooManyBeamStations As Int32 = 24
    Public Const ERR7_UnknownSubType As Int32 = 25
    Public Const ERR7_GroupIdDoesNotExist As Int32 = 26
    Public Const ERR7_InvalidFileUnit As Int32 = 27
    Public Const ERR7_CannotSaveFile As Int32 = 28
    Public Const ERR7_ResultFileIsOpen As Int32 = 29
    Public Const ERR7_InvalidUnits As Int32 = 30
    Public Const ERR7_InvalidEntityNodes As Int32 = 31
    Public Const ERR7_InvalidUCSType As Int32 = 32
    Public Const ERR7_InvalidUCSID As Int32 = 33
    Public Const ERR7_UCSIDAlreadyExists As Int32 = 34
    Public Const ERR7_CaseNameAlreadyExists As Int32 = 35
    Public Const ERR7_InvalidEntityNumber As Int32 = 36
    Public Const ERR7_InvalidBeamEnd As Int32 = 37
    Public Const ERR7_InvalidBeamDir As Int32 = 38
    Public Const ERR7_InvalidPlateEdge As Int32 = 39
    Public Const ERR7_InvalidBrickFace As Int32 = 40
    Public Const ERR7_InvalidBeamType As Int32 = 41
    Public Const ERR7_InvalidPlateType As Int32 = 42
    Public Const ERR7_InvalidMaterialType As Int32 = 43
    Public Const ERR7_PropertyAlreadyExists As Int32 = 44
    Public Const ERR7_InvalidBeamSectionType As Int32 = 45
    Public Const ERR7_PropertyNotSpring As Int32 = 46
    Public Const ERR7_PropertyNotCable As Int32 = 47
    Public Const ERR7_PropertyNotTruss As Int32 = 48
    Public Const ERR7_PropertyNotCutOffBar As Int32 = 49
    Public Const ERR7_PropertyNotPointContact As Int32 = 50
    Public Const ERR7_PropertyNotBeam As Int32 = 51
    Public Const ERR7_PropertyNotPipe As Int32 = 52
    Public Const ERR7_PropertyNotConnectionBeam As Int32 = 53
    Public Const ERR7_InvalidSectionParameters As Int32 = 54
    Public Const ERR7_PropertyNotUserDefinedBeam As Int32 = 55
    Public Const ERR7_MaterialIsUserDefined As Int32 = 56
    Public Const ERR7_MaterialNotIsotropic As Int32 = 57
    Public Const ERR7_MaterialNotOrthotropic As Int32 = 58
    Public Const ERR7_InvalidRubberModel As Int32 = 59
    Public Const ERR7_MaterialNotRubber As Int32 = 60
    Public Const ERR7_InvalidSectionProperties As Int32 = 61
    Public Const ERR7_PlateDoesNotHaveThickness As Int32 = 62
    Public Const ERR7_IncompatibleMaterialCombination As Int32 = 63
    Public Const ERR7_UnknownSolver As Int32 = 64
    Public Const ERR7_InvalidSolverMode As Int32 = 65
    Public Const ERR7_InvalidMirrorOption As Int32 = 66
    Public Const ERR7_SectionCannotBeMirrored As Int32 = 67
    Public Const ERR7_InvalidTableType As Int32 = 68
    Public Const ERR7_InvalidTableName As Int32 = 69
    Public Const ERR7_TableNameAlreadyExists As Int32 = 70
    Public Const ERR7_InvalidNumberOfEntries As Int32 = 71
    Public Const ERR7_InvalidZipType As Int32 = 72
    Public Const ERR7_TableDoesNotExist As Int32 = 73
    Public Const ERR7_NotFrequencyTable As Int32 = 74
    Public Const ERR7_InvalidFrequencyType As Int32 = 75
    Public Const ERR7_InvalidTableSetting As Int32 = 76
    Public Const ERR7_IncompatibleTableType As Int32 = 77
    Public Const ERR7_IncompatibleCriterionCombination As Int32 = 78
    Public Const ERR7_InvalidModalFile As Int32 = 79
    Public Const ERR7_InvalidCombinationCaseNumber As Int32 = 80
    Public Const ERR7_InvalidInitialCaseNumber As Int32 = 81
    Public Const ERR7_InvalidInitialFile As Int32 = 82
    Public Const ERR7_InvalidModeNumber As Int32 = 83
    Public Const ERR7_BeamIsNotBXS As Int32 = 84
    Public Const ERR7_InvalidDampingType As Int32 = 85
    Public Const ERR7_InvalidRayleighMode As Int32 = 86
    Public Const ERR7_CannotReadBXS As Int32 = 87
    Public Const ERR7_InvalidResultType As Int32 = 88
    Public Const ERR7_InvalidSolverParameter As Int32 = 89
    Public Const ERR7_InvalidModalLoadType As Int32 = 90
    Public Const ERR7_InvalidTimeRow As Int32 = 91
    Public Const ERR7_SparseSolverNotLicenced As Int32 = 92
    Public Const ERR7_InvalidSolverScheme As Int32 = 93
    Public Const ERR7_InvalidSortOption As Int32 = 94
    Public Const ERR7_IncompatibleResultFile As Int32 = 95
    Public Const ERR7_InvalidLinkType As Int32 = 96
    Public Const ERR7_InvalidLinkData As Int32 = 97
    Public Const ERR7_OnlyOneLoadCase As Int32 = 98
    Public Const ERR7_OnlyOneFreedomCase As Int32 = 99
    Public Const ERR7_InvalidLoadID As Int32 = 100
    Public Const ERR7_InvalidBeamLoadType As Int32 = 101
    Public Const ERR7_InvalidStringID As Int32 = 102
    Public Const ERR7_InvalidPatchType As Int32 = 103
    Public Const ERR7_IncrementDoesNotExist As Int32 = 104
    Public Const ERR7_InvalidLoadCaseType As Int32 = 105
    Public Const ERR7_InvalidFreedomCaseType As Int32 = 106
    Public Const ERR7_InvalidHarmonicLoadType As Int32 = 107
    Public Const ERR7_InvalidTemperatureType As Int32 = 108
    Public Const ERR7_InvalidPatchTypeForPlate As Int32 = 109
    Public Const ERR7_InvalidAttributeType As Int32 = 110
    Public Const ERR7_MaterialNotAnisotropic As Int32 = 111
    Public Const ERR7_InvalidMatrixType As Int32 = 112
    Public Const ERR7_MaterialNotUserDefined As Int32 = 113
    Public Const ERR7_InvalidIndex As Int32 = 114
    Public Const ERR7_InvalidContactType As Int32 = 115
    Public Const ERR7_InvalidContactSubType As Int32 = 116
    Public Const ERR7_InvalidCutoffType As Int32 = 117
    Public Const ERR7_ResultQuantityNotAvailable As Int32 = 118
    Public Const ERR7_YieldNotMCDP As Int32 = 119
    Public Const ERR7_CombinationDoesNotExist As Int32 = 120
    Public Const ERR7_InvalidSeismicCase As Int32 = 121
    Public Const ERR7_InvalidImportExportMode As Int32 = 122
    Public Const ERR7_CannotReadImportFile As Int32 = 123
    Public Const ERR7_InvalidAnsysImportFormat As Int32 = 124
    Public Const ERR7_InvalidAnsysArrayStatus As Int32 = 125
    Public Const ERR7_CannotWriteExportFile As Int32 = 126
    Public Const ERR7_InvalidAnsysExportFormat As Int32 = 127
    Public Const ERR7_InvalidAnsysEndReleaseOption As Int32 = 128
    Public Const ERR7_InvalidAnsysExportUnits As Int32 = 129
    Public Const ERR7_InvalidSt7ExportFormat As Int32 = 130
    Public Const ERR7_InvalidUVPos As Int32 = 131
    Public Const ERR7_InvalidResponseType As Int32 = 132
    Public Const ERR7_InvalidLayoutID As Int32 = 133
    Public Const ERR7_InvalidPlateSurface As Int32 = 134
    Public Const ERR7_MeshingErrors As Int32 = 135
    Public Const ERR7_InvalidZipTolerance As Int32 = 136
    Public Const ERR7_InvalidTaperAxis As Int32 = 137
    Public Const ERR7_InvalidTaperType As Int32 = 138
    Public Const ERR7_InvalidTaperRatio As Int32 = 139
    Public Const ERR7_InvalidPositionType As Int32 = 140
    Public Const ERR7_InvalidPreLoadType As Int32 = 141
    Public Const ERR7_InvalidVertexType As Int32 = 142
    Public Const ERR7_InvalidVertexMeshSize As Int32 = 143
    Public Const ERR7_InvalidGeometryEdgeType As Int32 = 144
    Public Const ERR7_InvalidPropertyNumber As Int32 = 145
    Public Const ERR7_InvalidFaceSurface As Int32 = 146
    Public Const ERR7_InvalidModType As Int32 = 147
    Public Const ERR7_MaterialNotSoil As Int32 = 148
    Public Const ERR7_MaterialNotFluid As Int32 = 149
    Public Const ERR7_SoilTypeNotDC As Int32 = 150
    Public Const ERR7_SoilTypeNotCC As Int32 = 151
    Public Const ERR7_MaterialNotLaminate As Int32 = 152
    Public Const ERR7_InvalidLaminateID As Int32 = 153
    Public Const ERR7_LaminateNameAlreadyExists As Int32 = 154
    Public Const ERR7_LaminateIDAlreadyExists As Int32 = 155
    Public Const ERR7_PlyDoesNotExist As Int32 = 156
    Public Const ERR7_ExceededMaxNumPlies As Int32 = 157
    Public Const ERR7_LayoutIDAlreadyExists As Int32 = 158
    Public Const ERR7_InvalidNumModes As Int32 = 159
    Public Const ERR7_InvalidLTAMethod As Int32 = 160
    Public Const ERR7_InvalidLTASolutionType As Int32 = 161
    Public Const ERR7_ExceededMaxNumStages As Int32 = 162
    Public Const ERR7_StageDoesNotExist As Int32 = 163
    Public Const ERR7_ExceededMaxNumSpectralCases As Int32 = 164
    Public Const ERR7_InvalidSpectralCase As Int32 = 165
    Public Const ERR7_InvalidSpectrumType As Int32 = 166
    Public Const ERR7_InvalidResultsSign As Int32 = 167
    Public Const ERR7_InvalidPositionTableAxis As Int32 = 168
    Public Const ERR7_InvalidInitialConditionsType As Int32 = 169
    Public Const ERR7_ExceededMaxNumNodeHistory As Int32 = 170
    Public Const ERR7_NodeHistoryDoesNotExist As Int32 = 171
    Public Const ERR7_InvalidTransientTempType As Int32 = 172
    Public Const ERR7_InvalidTimeUnit As Int32 = 173
    Public Const ERR7_InvalidLoadPath As Int32 = 174
    Public Const ERR7_InvalidTempDependenceType As Int32 = 175
    Public Const ERR7_InvalidTrigType As Int32 = 176
    Public Const ERR7_InvalidUserEquation As Int32 = 177
    Public Const ERR7_InvalidCreepID As Int32 = 178
    Public Const ERR7_CreepIDAlreadyExists As Int32 = 179
    Public Const ERR7_InvalidCreepLaw As Int32 = 180
    Public Const ERR7_InvalidCreepHardeningLaw As Int32 = 181
    Public Const ERR7_InvalidCreepViscoChainRow As Int32 = 182
    Public Const ERR7_InvalidCreepFunctionType As Int32 = 183
    Public Const ERR7_InvalidCreepShrinkageType As Int32 = 184
    Public Const ERR7_InvalidTableRow As Int32 = 185
    Public Const ERR7_ExceededMaxNumRows As Int32 = 186
    Public Const ERR7_InvalidLoadPathTemplateID As Int32 = 187
    Public Const ERR7_LoadPathTemplateIDAlreadyExists As Int32 = 188
    Public Const ERR7_InvalidLoadPathLane As Int32 = 189
    Public Const ERR7_ExceededMaxNumLoadPathTemplates As Int32 = 190
    Public Const ERR7_ExceededMaxNumLoadPathVehicles As Int32 = 191
    Public Const ERR7_InvalidLoadPathVehicle As Int32 = 192
    Public Const ERR7_InvalidMobilityType As Int32 = 193
    Public Const ERR7_InvalidAxisSystem As Int32 = 194
    Public Const ERR7_InvalidLoadPathID As Int32 = 195
    Public Const ERR7_LoadPathIDAlreadyExists As Int32 = 196
    Public Const ERR7_InvalidPathDefinition As Int32 = 197
    Public Const ERR7_InvalidLoadPathShape As Int32 = 198
    Public Const ERR7_InvalidLoadPathSurface As Int32 = 199
    Public Const ERR7_InvalidNumPathDivs As Int32 = 200
    Public Const ERR7_InvalidGeometryCavityLoop As Int32 = 201
    Public Const ERR7_InvalidLimitEnvelope As Int32 = 202
    Public Const ERR7_ExceededMaxNumLimitEnvelopes As Int32 = 203
    Public Const ERR7_InvalidCombEnvelope As Int32 = 204
    Public Const ERR7_ExceededMaxNumCombEnvelopes As Int32 = 205
    Public Const ERR7_InvalidFactorsEnvelope As Int32 = 206
    Public Const ERR7_ExceededMaxNumFactorsEnvelopes As Int32 = 207
    Public Const ERR7_InvalidLimitEnvelopeType As Int32 = 208
    Public Const ERR7_InvalidCombEnvelopeType As Int32 = 209
    Public Const ERR7_InvalidFactorsEnvelopeType As Int32 = 210
    Public Const ERR7_InvalidCombEnvelopeAccType As Int32 = 211
    Public Const ERR7_InvalidEnvelopeSet As Int32 = 212
    Public Const ERR7_ExceededMaxNumEnvelopeSets As Int32 = 213
    Public Const ERR7_InvalidEnvelopeSetType As Int32 = 214
    Public Const ERR7_InvalidCombResFile As Int32 = 215
    Public Const ERR7_ExceededMaxNumCombResFiles As Int32 = 216
    Public Const ERR7_CannotCombResFiles As Int32 = 217
    Public Const ERR7_InvalidStartEndTimes As Int32 = 218
    Public Const ERR7_InvalidNumSteps As Int32 = 219
    Public Const ERR7_InvalidLibraryPath As Int32 = 220
    Public Const ERR7_InvalidLibraryType As Int32 = 221
    Public Const ERR7_InvalidLibraryID As Int32 = 222
    Public Const ERR7_InvalidLibraryName As Int32 = 223
    Public Const ERR7_InvalidLibraryItemID As Int32 = 224
    Public Const ERR7_InvalidLibraryItemName As Int32 = 225
    Public Const ERR7_InvalidDisplayOptionsPath As Int32 = 226
    Public Const ERR7_InvalidSolverPath As Int32 = 227
    Public Const ERR7_InvalidCementHardeningType As Int32 = 228
    Public Const ERR7_ZeroPlateElements As Int32 = 229
    Public Const ERR7_CannotMakeBXS As Int32 = 230
    Public Const ERR7_CannotCalculateBXSData As Int32 = 231
    Public Const ERR7_InvalidSurfaceMeshTargetType As Int32 = 232
    Public Const ERR7_InvalidModalNodeReactType As Int32 = 233
    Public Const ERR7_InvalidAxis As Int32 = 234
    Public Const ERR7_InvalidBeamAxisType As Int32 = 235
    Public Const ERR7_InvalidStaadCountryCodeOption As Int32 = 236
    Public Const ERR7_InvalidGeometryFormatProtocol As Int32 = 237
    Public Const ERR7_InvalidDXFBeamOption As Int32 = 238
    Public Const ERR7_InvalidDXFPlateOption As Int32 = 239
    Public Const ERR7_InvalidLoadPathLaneFactorType As Int32 = 240
    Public Const ERR7_InvalidLoadPathVehicleInstance As Int32 = 241
    Public Const ERR7_InvalidNumBeamStations As Int32 = 242
    Public Const ERR7_ResFileUnsupportedType As Int32 = 243
    Public Const ERR7_ResFileAlreadyOpen As Int32 = 244
    Public Const ERR7_ResFileInvalidNumCases As Int32 = 245
    Public Const ERR7_ResFileNotOpen As Int32 = 246
    Public Const ERR7_ResFileInvalidCase As Int32 = 247
    Public Const ERR7_ResFileDoesNotHaveEntity As Int32 = 248
    Public Const ERR7_ResFileInvalidQuantity As Int32 = 249
    Public Const ERR7_ResFileQuantityNotExist As Int32 = 250
    Public Const ERR7_ResFileCantSave As Int32 = 251
    Public Const ERR7_ResFileCantClearQuantity As Int32 = 252
    Public Const ERR7_ResFileContainsNoElements As Int32 = 253
    Public Const ERR7_ResFileContainsNoNodes As Int32 = 254
    Public Const ERR7_ResFileInvalidName As Int32 = 255
    Public Const ERR7_ResFileAssociationNotAllowed As Int32 = 256
    Public Const ERR7_ResFileIncompatibleQuantity As Int32 = 257
    Public Const ERR7_CannotEditSolverFiles As Int32 = 258
    Public Const ERR7_CannotOpenResultFile As Int32 = 259
    Public Const ERR7_CouldNotShowModelWindow As Int32 = 260
    Public Const ERR7_ModelWindowWasNotShowing As Int32 = 261
    Public Const ERR7_CantDoWithModalWindows As Int32 = 262
    Public Const ERR7_InvalidSelectionEndEdgeFace As Int32 = 263
    Public Const ERR7_CouldNotCreateModelWindow As Int32 = 264
    Public Const ERR7_ModelWindowWasNotCreated As Int32 = 265
    Public Const ERR7_InvalidImageType As Int32 = 266
    Public Const ERR7_InvalidImageDimensions As Int32 = 267
    Public Const ERR7_InsufficientRamToCreateImage As Int32 = 268
    Public Const ERR7_CannotSaveImageFile As Int32 = 269
    Public Const ERR7_InvalidWindowDimensions As Int32 = 270
    Public Const ERR7_InvalidResultQuantity As Int32 = 271
    Public Const ERR7_InvalidResultSubQuantity As Int32 = 272
    Public Const ERR7_InvalidComponent As Int32 = 273
    Public Const ERR7_ResultIsNotAvailable As Int32 = 274
    Public Const ERR7_InvalidUCSIndex As Int32 = 275
    Public Const ERR7_InvalidDiagramAxis As Int32 = 276
    Public Const ERR7_InvalidVectorComponents As Int32 = 277
    Public Const ERR7_TableTypeIsNotTimeBased As Int32 = 278
    Public Const ERR7_InvalidTableID As Int32 = 279
    Public Const ERR7_LinkNotMasterSlave As Int32 = 280
    Public Const ERR7_LinkNotSectorSymmetry As Int32 = 281
    Public Const ERR7_LinkNotCoupling As Int32 = 282
    Public Const ERR7_LinkNotPinned As Int32 = 283
    Public Const ERR7_LinkNotRigid As Int32 = 284
    Public Const ERR7_LinkNotShrink As Int32 = 285
    Public Const ERR7_LinkNotTwoPoint As Int32 = 286
    Public Const ERR7_LinkNotAttachment As Int32 = 287
    Public Const ERR7_LinkNotMultiPoint As Int32 = 288
    Public Const ERR7_InvalidCoupleType As Int32 = 289
    Public Const ERR7_InvalidRigidPlane As Int32 = 290
    Public Const ERR7_InvalidMultiPointFactorsType As Int32 = 291
    Public Const ERR7_InvalidMultiPointLink As Int32 = 292
    Public Const ERR7_InvalidAttachmentType As Int32 = 293
    Public Const ERR7_ExceededMaxNumColumns As Int32 = 294
    Public Const ERR7_CouldNotDestroyModelWindow As Int32 = 295
    Public Const ERR7_CannotSetWindowParent As Int32 = 296
    Public Const ERR7_InvalidLoadCaseFilePath As Int32 = 297
    Public Const ERR7_InvalidStaadLengthUnit As Int32 = 298
    Public Const ERR7_InvalidStaadForceUnit As Int32 = 299
    Public Const ERR7_InvalidDuplicateFaceType As Int32 = 300
    Public Const ERR7_InvalidNodeCoordinateKeepType As Int32 = 301
    Public Const ERR7_CommentDoesNotExist As Int32 = 302
    Public Const ERR7_InvalidFilePath As Int32 = 303
    Public Const ERR7_InvalidContactYieldType As Int32 = 304
    Public Const ERR7_InvalidNumMeshingLoops As Int32 = 305
    Public Const ERR7_InvalidMeshPositionOnUCS As Int32 = 306
    Public Const ERR7_InvalidK0Expression As Int32 = 307
    Public Const ERR7_InvalidK1Expression As Int32 = 308
    Public Const ERR7_NoPatchLoadsCreated As Int32 = 309
    Public Const ERR7_InvalidResOptsBeamEnvelope As Int32 = 310
    Public Const ERR7_InvalidResOptsRotationUnit As Int32 = 311
    Public Const ERR7_InvalidResOptsHRASetting As Int32 = 312
    Public Const ERR7_InvalidResOptsStageDisplacement As Int32 = 313
    Public Const ERR7_InvalidToolOptsZipOptions As Int32 = 314
    Public Const ERR7_InvalidToolOptsSubdivideOptions As Int32 = 315
    Public Const ERR7_InvalidToolOptsCopyOptions As Int32 = 316
    Public Const ERR7_InvalidToleranceType As Int32 = 317
    Public Const ERR7_InvalidAttachPartsParams As Int32 = 318
    Public Const ERR7_InvalidDrawParameters As Int32 = 319
    Public Const ERR7_FilesStillOpen As Int32 = 320
    Public Const ERR7_SolverStillRunning As Int32 = 321
    Public Const ERR7_InvalidPolygonToFaceParameters As Int32 = 322
    Public Const ERR7_InvalidResOptsStrainUnit As Int32 = 323
    Public Const ERR7_FunctionNotSupported As Int32 = 324
    Public Const ERR7_SoilTypeNotMC As Int32 = 325
    Public Const ERR7_SoilTypeNotDP As Int32 = 326
    Public Const ERR7_TooManyAnimations As Int32 = 327
    Public Const ERR7_InvalidAnimationFile As Int32 = 328
    Public Const ERR7_InvalidAnimationMode As Int32 = 329
    Public Const ERR7_InsufficientFrames As Int32 = 330
    Public Const ERR7_AnimationDimensionsTooSmall As Int32 = 331
    Public Const ERR7_AnimationDimensionsTooLarge As Int32 = 332
    Public Const ERR7_ReducedAnimation As Int32 = 333
    Public Const ERR7_InvalidAnimationType As Int32 = 334
    Public Const ERR7_CannotFindStubFile As Int32 = 335
    Public Const ERR7_CouldNotSaveAnimationFile As Int32 = 336
    Public Const ERR7_AnimationHandleOutOfRange As Int32 = 337
    Public Const ERR7_AnimationNotRunning As Int32 = 338
    Public Const ERR7_SoilTypeNotLS As Int32 = 339
    Public Const ERR7_NoPolygonWasConverted As Int32 = 340
    Public Const ERR7_InvalidAlphaTempType As Int32 = 341
    Public Const ERR7_InvalidGravityDirection As Int32 = 342
    Public Const ERR7_InvalidAttachmentDirection As Int32 = 343
    Public Const ERR7_InvalidHardeningType As Int32 = 344
    Public Const ERR7_ResultCaseNotInertiaRelief As Int32 = 345
    Public Const ERR7_InvalidNumLayers As Int32 = 346
    Public Const ERR7_PlateDoesNotHaveLayers As Int32 = 347
    Public Const ERR7_ToolOperationFailed As Int32 = 348

    Rem Solver Error Codes
    Public Const SE_NoLoadCaseSelected As Int32 = 1001
    Public Const SE_IncompatibleRestartFile As Int32 = 1002
    Public Const SE_ElementUsesInvalidProperty As Int32 = 1003
    Public Const SE_InvalidElement As Int32 = 1004
    Public Const SE_NeedNonlinearHeatSolver As Int32 = 1005
    Public Const SE_TableNotFound As Int32 = 1006
    Public Const SE_InvalidRestartFile As Int32 = 1007
    Public Const SE_InvalidInitialFile As Int32 = 1008
    Public Const SE_InvalidSolverResultFile As Int32 = 1009
    Public Const SE_InvalidLink As Int32 = 1010
    Public Const SE_InvalidPlateCohesionValue As Int32 = 1011
    Public Const SE_InvalidBrickCohesionValue As Int32 = 1012
    Public Const SE_NonlinearSolverRequired As Int32 = 1013
    Public Const SE_NoLoadTablesDefined As Int32 = 1014
    Public Const SE_NoVelocityDataInInitialFile As Int32 = 1015
    Public Const SE_NoModesIncluded As Int32 = 1016
    Public Const SE_InvalidTimeStep As Int32 = 1017
    Public Const SE_LoadIncrementsNotDefined As Int32 = 1018
    Public Const SE_NoFreedomCaseInIncrements As Int32 = 1019
    Public Const SE_InvalidInitialTemperatureFile As Int32 = 1020
    Public Const SE_InvalidFrequencyRange As Int32 = 1021
    Public Const SE_ModelMixesAxiNonAxi As Int32 = 1022
    Public Const SE_CompositeModuleNotAvailable As Int32 = 1023
    Public Const SE_CannotFindSolver As Int32 = 1024
    Public Const SE_UnknownException As Int32 = 1025
    Public Const SE_DuplicateLinks As Int32 = 1026
    Public Const SE_CannotAppendToFile As Int32 = 1027
    Public Const SE_CannotOverwriteFile As Int32 = 1028
    Public Const SE_CannotWriteToResultFile As Int32 = 1029
    Public Const SE_CannotWriteToLogFile As Int32 = 1030
    Public Const SE_CannotReadRestartFile As Int32 = 1031
    Public Const SE_InitialConditionsNotValid As Int32 = 1032
    Public Const SE_InvalidRayleighFactors As Int32 = 1033
    Public Const SE_ShearPanelMustBeQuad4 As Int32 = 1035
    Public Const SE_SingularPlateMatrix As Int32 = 1036
    Public Const SE_SingularBrickMatrix As Int32 = 1037
    Public Const SE_NoBeamProperties As Int32 = 1038
    Public Const SE_NoPlateProperties As Int32 = 1039
    Public Const SE_NoBrickProperties As Int32 = 1040
    Public Const SE_MoreLoadIncrementsNeeded As Int32 = 1041
    Public Const SE_RubberRequiresGNL As Int32 = 1042
    Public Const SE_NoFreedomCaseSelected As Int32 = 1043
    Public Const SE_InvalidSpectralVectors As Int32 = 1044
    Public Const SE_NoSpectralResultsSelected As Int32 = 1045
    Public Const SE_SpectralFactorsNotDefined As Int32 = 1046
    Public Const SE_SpectralFactorsAllZero As Int32 = 1047
    Public Const SE_NoTimeStepsSaved As Int32 = 1048
    Public Const SE_InvalidDirectionVector As Int32 = 1049
    Public Const SE_HarmonicFactorsAllZero As Int32 = 1050
    Public Const SE_TemperatureDependenceCaseNotSet As Int32 = 1051
    Public Const SE_ZeroLengthRigidLinkGenerated As Int32 = 1052
    Public Const SE_InvalidStringGroupDefinition As Int32 = 1053
    Public Const SE_InvalidPreTensionOnString As Int32 = 1054
    Public Const SE_StringOrderHasChanged As Int32 = 1055
    Public Const SE_BadTaperData As Int32 = 1056
    Public Const SE_TaperedPlasticBeams As Int32 = 1057
    Public Const SE_NoMovingLoadPathsInCases As Int32 = 1058
    Public Const SE_NoResponseVariablesDefined As Int32 = 1059
    Public Const SE_InvalidPlateVariableRequested As Int32 = 1060
    Public Const SE_InvalidGravityCase As Int32 = 1061
    Public Const SE_InvalidUserPlateCreepDefinition As Int32 = 1062
    Public Const SE_InvalidUserBrickCreepDefinition As Int32 = 1063
    Public Const SE_InvalidPlateShrinkageDefinition As Int32 = 1064
    Public Const SE_InvalidBrickShrinkageDefinition As Int32 = 1065
    Public Const SE_InvalidLaminateID As Int32 = 1066
    Public Const SE_CannotReadWriteScratchPath As Int32 = 1067
    Public Const SE_CannotConvertAttachmentLink As Int32 = 1068
    Public Const SE_SoilRequiresMNL As Int32 = 1069
    Public Const SE_ActiveStageHasNoIncrements As Int32 = 1070
    Public Const SE_ConcreteCreepMNL As Int32 = 1071
    Public Const SE_CannotConvertInterpMultiPoint As Int32 = 1072
    Public Const SE_MissingInsituStress As Int32 = 1073
    Public Const SE_InvalidMaterialNonlinearString As Int32 = 1074
    Public Const SE_TensileInsituPlateStress As Int32 = 1075
    Public Const SE_TensileInsituBrickStress As Int32 = 1076
    Public Const SE_IncompatibleRestartUnits As Int32 = 1077
    Public Const SE_CreepTimeTooShort As Int32 = 1078
    Public Const SE_InvalidElements As Int32 = 1079
    Public Const SE_InsufficientRestartFileSteps As Int32 = 1080
    Public Const SE_NeedNodeTempNTASolver As Int32 = 1081
    Public Const SE_SingleShotRestartFile As Int32 = 1082
    Public Const SE_SkylineUsesBadSort As Int32 = 1083
    Public Const SE_StagedSolutionFileNotFound As Int32 = 1084
    Public Const SE_NeedTemperatureTables As Int32 = 1085
    Public Const SE_AttachmentsInWrongGroup As Int32 = 1086
    Public Const SE_StagingHasChanged As Int32 = 1087
    Public Const SE_NoNodes As Int32 = 1088
    Public Const SE_CQCRequiresDamping As Int32 = 1089

    Rem Other Constants
    Public Const kMaxPlateResult As Int32 = 1024
    Public Const kMaxBrickResult As Int32 = 1024
    Public Const kMaxBeamRelease As Int32 = 12
    Public Const kMaxDisp As Int32 = 6
    Public Const kAllStations As Int32 = 20

    Rem UCS
    Public Const kMaxUCSDoubles As Int32 = 10

    Rem Solvers
    Public Const stLinearStaticSolver As Int32 = 1
    Public Const stLinearBucklingSolver As Int32 = 2
    Public Const stNonlinearStaticSolver As Int32 = 3
    Public Const stNaturalFrequencySolver As Int32 = 4
    Public Const stHarmonicResponseSolver As Int32 = 5
    Public Const stSpectralResponseSolver As Int32 = 6
    Public Const stLinearTransientDynamicSolver As Int32 = 7
    Public Const stNonlinearTransientDynamicSolver As Int32 = 8
    Public Const stSteadyHeatSolver As Int32 = 9
    Public Const stTransientHeatSolver As Int32 = 10
    Public Const stLoadInfluenceSolver As Int32 = 11
    Public Const stQuasiStaticSolver As Int32 = 12

    Rem Solver Modes
    Public Const smNormalRun As Int32 = 1
    Public Const smProgressRunsmNormalCloseRun As Int32 = 2
    Public Const smBackgroundRun As Int32 = 3
    Public Const smNormalCloseRun As Int32 = 4

    Rem Primary Load Case
    Public Const ipLoadCaseDefRefTemp As Int32 = 0
    Public Const ipLoadCaseDefOriginX As Int32 = 1
    Public Const ipLoadCaseDefOriginY As Int32 = 2
    Public Const ipLoadCaseDefOriginZ As Int32 = 3
    Public Const ipLoadCaseDefLinAccX As Int32 = 4
    Public Const ipLoadCaseDefLinAccY As Int32 = 5
    Public Const ipLoadCaseDefLinAccZ As Int32 = 6
    Public Const ipLoadCaseDefAngVelX As Int32 = 7
    Public Const ipLoadCaseDefAngVelY As Int32 = 8
    Public Const ipLoadCaseDefAngVelZ As Int32 = 9
    Public Const ipLoadCaseDefAngAccX As Int32 = 10
    Public Const ipLoadCaseDefAngAccY As Int32 = 11
    Public Const ipLoadCaseDefAngAccZ As Int32 = 12

    Rem Seismic Load Case
    Public Const ipSeismicCaseDefAlpha As Int32 = 0
    Public Const ipSeismicCaseDefPhi As Int32 = 1
    Public Const ipSeismicCaseDefBeta As Int32 = 2
    Public Const ipSeismicCaseDefK As Int32 = 3
    Public Const ipSeismicCaseDefh0 As Int32 = 4
    Public Const ipSeismicCaseDefDir As Int32 = 5
    Public Const ipSeismicCaseDefLinAcc As Int32 = 6
    Public Const ipSeismicCaseDefV1 As Int32 = 7
    Public Const ipSeismicCaseDefV2 As Int32 = 8

    Rem Import/Export Modes
    Public Const ieQuietRun As Int32 = 0
    Public Const ieProgressRun As Int32 = 1

    Rem NASTRAN
    Public Const ipNASTRANImportUnits As Int32 = 0
    Public Const ipNASTRANFreedomCase As Int32 = 0
    Public Const ipNASTRANLoadCase As Int32 = 1
    Public Const ipNASTRANSolver As Int32 = 2
    Public Const ipNASTRANExportUnits As Int32 = 3
    Public Const ipNASTRANBeamStressSections As Int32 = 4
    Public Const ipNASTRANBeamSectionGeometry As Int32 = 5
    Public Const ipNASTRANExportHeatTransfer As Int32 = 6
    Public Const ipNASTRANExportNSMass As Int32 = 7
    Public Const ipNASTRANExportUnusedProps As Int32 = 8
    Public Const ipNASTRANTemperatureCase As Int32 = 9
    Public Const ipNASTRANExportZeroFields As Int32 = 0
    Public Const ieNASTRANSolverLSA As Int32 = 0
    Public Const ieNASTRANSolverNFA As Int32 = 1
    Public Const ieNASTRANSolverLBA As Int32 = 2
    Public Const ieNASTRANExportGeometryProps As Int32 = 0
    Public Const ieNASTRANExportPropsOnly As Int32 = 1
    Public Const naUnits_kg_N_m As Int32 = 0
    Public Const naUnits_T_N_mm As Int32 = 1
    Public Const naUnits_sl_lbf_ft As Int32 = 2
    Public Const naUnits_lbm_lbf_in As Int32 = 3
    Public Const naUnits_sl_lbf_in As Int32 = 4
    Public Const naUnits_NoUnits As Int32 = 5

    Rem ANSYS
    Public Const ipANSYSImportFormat As Int32 = 0
    Public Const ipANSYSArrayParameters As Int32 = 1
    Public Const ipANSYSImportLoadCaseFiles As Int32 = 2
    Public Const ipANSYSImportIGESEntities As Int32 = 3
    Public Const ipANSYSFixElementConnectivity As Int32 = 4
    Public Const ipANSYSRemoveDuplicateProps As Int32 = 5
    Public Const ipANSYSExportFormat As Int32 = 0
    Public Const ipANSYSFreedomCase As Int32 = 1
    Public Const ipANSYSLoadCase As Int32 = 2
    Public Const ipANSYSUnits As Int32 = 3
    Public Const ipANSYSEndRelease As Int32 = 4
    Public Const ipANSYSExportNonlinearMat As Int32 = 5
    Public Const ipANSYSExportHeatTransfer As Int32 = 6
    Public Const ipANSYSExportPreLoadNSMass As Int32 = 7
    Public Const ipANSYSExportTetraOption As Int32 = 8
    Public Const ieANSYSBatchImport As Int32 = 0
    Public Const ieANSYSCDBImport As Int32 = 1
    Public Const ieANSYSBatchCDBImport As Int32 = 2
    Public Const ieANSYSBatch1Export As Int32 = 0
    Public Const ieANSYSBatch3Export As Int32 = 1
    Public Const ieANSYSBlockedCDBExport As Int32 = 2
    Public Const ieANSYSUnblockedCDBExport As Int32 = 3
    Public Const ieANSYSArrayOverwrite As Int32 = 0
    Public Const ieANSYSArrayIgnore As Int32 = 1
    Public Const ieANSYSArrayPrompt As Int32 = 2
    Public Const ieANSYSEndReleaseFixed As Int32 = 0
    Public Const ieANSYSEndReleaseFull As Int32 = 1
    Public Const anUnits_NoUnits As Int32 = 0
    Public Const anUnits_kg_m_C As Int32 = 1
    Public Const anUnits_g_cm_C As Int32 = 2
    Public Const anUnits_T_mm_C As Int32 = 3
    Public Const anUnits_sl_ft_F As Int32 = 4
    Public Const anUnits_lbm_in_F As Int32 = 5

    Rem STAAD
    Public Const ipSTAADCountryType As Int32 = 0
    Public Const ipSTAADIncludeSectionLibrary As Int32 = 1
    Public Const ipSTAADStripUnderscore As Int32 = 2
    Public Const ipSTAADStripSectionSpaces As Int32 = 3
    Public Const ipSTAADLengthUnit As Int32 = 4
    Public Const ipSTAADForceUnit As Int32 = 5
    Public Const ieSTAADAmericanCode As Int32 = 0
    Public Const ieSTAADAustralianCode As Int32 = 1
    Public Const ieSTAADBritishCode As Int32 = 2
    Public Const sdLengthUnit_in As Int32 = 0
    Public Const sdLengthUnit_ft As Int32 = 1
    Public Const sdLengthUnit_cm As Int32 = 2
    Public Const sdLengthUnit_m As Int32 = 3
    Public Const sdLengthUnit_mm As Int32 = 4
    Public Const sdLengthUnit_dm As Int32 = 5
    Public Const sdLengthUnit_km As Int32 = 6
    Public Const sdForceUnit_kip As Int32 = 0
    Public Const sdForceUnit_lbf As Int32 = 1
    Public Const sdForceUnit_kgf As Int32 = 2
    Public Const sdForceUnit_MTf As Int32 = 3
    Public Const sdForceUnit_N As Int32 = 4
    Public Const sdForceUnit_kN As Int32 = 5
    Public Const sdForceUnit_MN As Int32 = 6
    Public Const sdForceUnit_dN As Int32 = 7

    Rem SAP2000
    Public Const ipSAP2000ConvertBlackTo As Int32 = 0
    Public Const ipSAP2000DecimalSeparator As Int32 = 1
    Public Const ipSAP2000ThousandSeparator As Int32 = 2
    Public Const ipSAP2000MergeDuplicateFreedomSets As Int32 = 3
    Public Const ieSAP2000Period As Int32 = 0
    Public Const ieSAP2000Comma As Int32 = 1
    Public Const ieSAP2000Space As Int32 = 2
    Public Const ieSAP2000None As Int32 = 3

    Rem ST7
    Public Const ieSt7ExportCurrent As Int32 = 0
    Public Const ieSt7Export106 As Int32 = 1
    Public Const ieSt7Export21x As Int32 = 2
    Public Const ieSt7Export22x As Int32 = 3
    Public Const ieSt7Export23x As Int32 = 4

    Rem GEOMETRY
    Public Const ipImportGeomProp As Int32 = 0
    Public Const ipImportGeomCurvesToBeams As Int32 = 1
    Public Const ipImportGeomGroupsAs As Int32 = 2
    Public Const ipImportGeomColourAsProperty As Int32 = 3
    Public Const ipImportGeomBlackReplacement As Int32 = 4
    Public Const ipImportGeomACISBodiesAsGroups As Int32 = 5
    Public Const ipImportGeomLengthUnit As Int32 = 6
    Public Const ipExportGeomColour As Int32 = 0
    Public Const ipExportGeomGroupsAsLevels As Int32 = 1
    Public Const ipExportGeomFullGroupPath As Int32 = 2
    Public Const ipExportGeomFormatProtocol As Int32 = 3
    Public Const ipExportGeomCurve As Int32 = 4
    Public Const ipExportGeomPeriodicFace As Int32 = 5
    Public Const ipExportGeomKeepAnalytic As Int32 = 6
    Public Const ipImportGeomTol As Int32 = 0
    Public Const luGeomNONE As Int32 = -1
    Public Const luGeomINCH As Int32 = 0
    Public Const luGeomMILLIMETRE As Int32 = 1
    Public Const luGeomFEET As Int32 = 2
    Public Const luGeomMILES As Int32 = 3
    Public Const luGeomMETRE As Int32 = 4
    Public Const luGeomKILOMETRE As Int32 = 5
    Public Const luGeomMIL As Int32 = 6
    Public Const luGeomMICRON As Int32 = 7
    Public Const luGeomCENTIMETRE As Int32 = 8
    Public Const luGeomMICROINCH As Int32 = 9
    Public Const luGeomUNSPECIFIED As Int32 = 10

    Rem Geometry Groups
    Public Const ggNone As Int32 = 0
    Public Const ggAuto As Int32 = 1
    Public Const ggSubfigures As Int32 = 2
    Public Const ggLevels As Int32 = 3
    Public Const ggAssemblies As Int32 = 1

    Rem IGES Formats
    Public Const ifBoundedSurface As Int32 = 0
    Public Const ifTrimmedParametricSurface As Int32 = 1
    Public Const ifOpenShell As Int32 = 2
    Public Const ifManifoldSolidBRep As Int32 = 3

    Rem STEP Protocols
    Public Const spConfigControlDesign As Int32 = 0
    Public Const spAutomotiveDesign As Int32 = 1

    Rem GEOMETRY Export Format Options
    Public Const ieModelOnly As Int32 = 0
    Public Const ieParameterOnly As Int32 = 1
    Public Const ieModelPreferred As Int32 = 2
    Public Const ieParameterPreferred As Int32 = 3
    Public Const ieSeamOnlyAsRequired As Int32 = 0
    Public Const ieSplitOnFaceBoundary As Int32 = 1
    Public Const ieSplitIntoHalves As Int32 = 2
    Public Const ieColourNone As Int32 = 0
    Public Const ieFaceColour As Int32 = 1
    Public Const ieGroupColour As Int32 = 2
    Public Const iePropertyColour As Int32 = 3

    Rem DXF Options
    Public Const ipDXFImportFrozenLayers As Int32 = 0
    Public Const ipDXFImportLayersAsGroups As Int32 = 1
    Public Const ipDXFImportColoursAsProps As Int32 = 2
    Public Const ipDXFImportPolylineAsPlates As Int32 = 3
    Public Const ipDXFImportPolygonAsBricks As Int32 = 4
    Public Const ipDXFImportSegmentsPerCircle As Int32 = 5
    Public Const ipDXFExportPlatesBricks3DFaces As Int32 = 0
    Public Const ipDXFExportGroupsAsLayers As Int32 = 1
    Public Const ipDXFExportPropColoursAsEntityColours As Int32 = 2
    Public Const ipDXFExportBeamsAs As Int32 = 3
    Public Const ipDXFExportPlatesAs As Int32 = 4
    Public Const bmLine As Int32 = 0
    Public Const bmSection As Int32 = 1
    Public Const bmSolid As Int32 = 2
    Public Const plSurface As Int32 = 0
    Public Const plSolid As Int32 = 1

    Rem Geometry Groups Settings
    Public Const grNone As Int32 = 0
    Public Const grAuto As Int32 = 1
    Public Const grSubfigures As Int32 = 2
    Public Const grLevels As Int32 = 3
    Public Const grAssembly As Int32 = 1

    Rem BXS
    Public Const ipBXSXBar As Int32 = 0
    Public Const ipBXSYBar As Int32 = 1
    Public Const ipBXSArea As Int32 = 2
    Public Const ipBXSI11 As Int32 = 3
    Public Const ipBXSI22 As Int32 = 4
    Public Const ipBXSAngle As Int32 = 5
    Public Const ipBXSZ11Plus As Int32 = 6
    Public Const ipBXSZ11Minus As Int32 = 7
    Public Const ipBXSZ22Plus As Int32 = 8
    Public Const ipBXSZ22Minus As Int32 = 9
    Public Const ipBXSS11 As Int32 = 10
    Public Const ipBXSS22 As Int32 = 11
    Public Const ipBXSr1 As Int32 = 12
    Public Const ipBXSr2 As Int32 = 13
    Public Const ipBXSSA1 As Int32 = 14
    Public Const ipBXSSA2 As Int32 = 15
    Public Const ipBXSSL1 As Int32 = 16
    Public Const ipBXSSL2 As Int32 = 17
    Public Const ipBXSIXX As Int32 = 18
    Public Const ipBXSIYY As Int32 = 19
    Public Const ipBXSIXY As Int32 = 20
    Public Const ipBXSIxxL As Int32 = 21
    Public Const ipBXSIyyL As Int32 = 22
    Public Const ipBXSIxyL As Int32 = 23
    Public Const ipBXSZxxPlus As Int32 = 24
    Public Const ipBXSZxxMinus As Int32 = 25
    Public Const ipBXSZyyPlus As Int32 = 26
    Public Const ipBXSZyyMinus As Int32 = 27
    Public Const ipBXSSxx As Int32 = 28
    Public Const ipBXSSyy As Int32 = 29
    Public Const ipBXSrx As Int32 = 30
    Public Const ipBXSry As Int32 = 31
    Public Const ipBXSJ As Int32 = 32
    Public Const ipBXSIw As Int32 = 33

    Rem GEOMETRY CLEAN - DOUBLES
    Public Const ipGeometryAccuracy As Int32 = 0
    Public Const ipGeometryFeatureLength As Int32 = 1
    Public Const ipGeometryEdgeMergeAngle As Int32 = 2

    Rem GEOMETRY CLEAN - INTEGERS
    Public Const ipGeometryAccuracyType As Int32 = 0
    Public Const ipGeometryFeatureType As Int32 = 1
    Public Const ipGeometryActOnWholeModel As Int32 = 2
    Public Const ipGeometryFreeEdgesOnly As Int32 = 3
    Public Const ipGeometryDuplicateFaces As Int32 = 4
    Public Const dfGeometryLeave As Int32 = 0
    Public Const dfGeometryDeleteOne As Int32 = 1
    Public Const dfGeometryDeleteBoth As Int32 = 2

    Rem MESH CLEAN - DOUBLES
    Public Const ipMeshTolerance As Int32 = 0

    Rem MESH CLEAN - INTEGERS
    Public Const ipMeshToleranceType As Int32 = 0
    Public Const ipZipNodes As Int32 = 1
    Public Const ipRemoveDuplicateElements As Int32 = 2
    Public Const ipFixElementConnectivity As Int32 = 3
    Public Const ipDeleteFreeNodes As Int32 = 4
    Public Const ipDoBeams As Int32 = 5
    Public Const ipDoPlates As Int32 = 6
    Public Const ipDoBricks As Int32 = 7
    Public Const ipDoLinks As Int32 = 8
    Public Const ipZeroLengthLinks As Int32 = 9
    Public Const ipZeroLengthBeams As Int32 = 10
    Public Const ipNodeAttributeKeep As Int32 = 11
    Public Const ipNodeCoordinates As Int32 = 12
    Public Const ipAllowDifferentProps As Int32 = 13
    Public Const ipActOnWholeModel As Int32 = 14
    Public Const dfLeaveAll As Int32 = 0
    Public Const dfLeaveOne As Int32 = 1
    Public Const dfLeaveNone As Int32 = 2

    Rem Attribute keep
    Public Const naLower As Int32 = 0
    Public Const naHigher As Int32 = 1
    Public Const naAccumulate As Int32 = 2

    Rem Node coordinates
    Public Const ncAverage As Int32 = 0
    Public Const ncLowerNode As Int32 = 1
    Public Const ncHigherNode As Int32 = 2
    Public Const ncSelectedNode As Int32 = 3

    Rem SURFACE MESHING - INTEGERS
    Public Const ipSurfaceMeshMode As Int32 = 0
    Public Const ipSurfaceMeshSizeMode As Int32 = 1
    Public Const ipSurfaceMeshTargetNodes As Int32 = 2
    Public Const ipSurfaceMeshTargetPropertyID As Int32 = 3
    Public Const ipSurfaceMeshAutoCreateProperties As Int32 = 4
    Public Const ipSurfaceMeshMinEdgesPerCircle As Int32 = 5
    Public Const ipSurfaceMeshApplyTransitioning As Int32 = 6
    Public Const ipSurfaceMeshAllowUserStop As Int32 = 7
    Public Const ipSurfaceMeshConsiderNearVertex As Int32 = 8
    Public Const mmAuto As Int32 = 0
    Public Const mmCustom As Int32 = 1
    Public Const smPercentage As Int32 = 0
    Public Const smAbsolute As Int32 = 1

    Rem SURFACE MESHING - DOUBLES
    Public Const ipSurfaceMeshSize As Int32 = 0
    Public Const ipSurfaceMeshLengthRatio As Int32 = 1
    Public Const ipSurfaceMeshMaximumIncrease As Int32 = 2
    Public Const ipSurfaceMeshOnEdgesLongerThan As Int32 = 3

    Rem TETRA MESHING
    Public Const ipTetraMeshSize As Int32 = 0
    Public Const ipTetraMeshProperty As Int32 = 1
    Public Const ipTetraMeshInc As Int32 = 2
    Public Const ipTetraMesh10 As Int32 = 3
    Public Const ipTetraMeshGroupsAsSolids As Int32 = 4
    Public Const ipTetraMeshSmooth As Int32 = 5
    Public Const ipTetraMeshAutoCreateProperties As Int32 = 7
    Public Const ipTetraMeshDeletePlates As Int32 = 8
    Public Const ipTetraMeshMultiBodyOption As Int32 = 9
    Public Const ipTetraMeshAllowUserStop As Int32 = 10
    Public Const ipTetraMeshCheckSelfIntersect As Int32 = 11
    Public Const msFine As Int32 = 1
    Public Const msMedium As Int32 = 2
    Public Const msCoarse As Int32 = 3
    Public Const mbCancelMeshing As Int32 = 0
    Public Const mbCavity As Int32 = 1
    Public Const mbSeparateSolids As Int32 = 2

    Rem Polygon Meshing
    Public Const ipMeshTargetNodes As Int32 = 0
    Public Const ipMeshTargetPropertyID As Int32 = 1
    Public Const ipMeshUCSID As Int32 = 2
    Public Const ipMeshGroupID As Int32 = 3
    Public Const ipMeshPositionUCS As Int32 = 0

    Rem IMAGE TYPES
    Public Const itBitmap8Bit As Int32 = 1
    Public Const itBitmap16Bit As Int32 = 2
    Public Const itBitmap24Bit As Int32 = 3
    Public Const itJPEG As Int32 = 4

    Rem WINDOW POPUP MENU GROUPS
    Public Const imView As Int32 = 1
    Public Const imDisplay As Int32 = 2
    Public Const imShow As Int32 = 3
    Public Const imSelect As Int32 = 4
    Public Const imResults As Int32 = 5

    Rem WINDOW STATE
    Public Const wsModelWindowNotCreated As Int32 = 0
    Public Const wsModelWindowVisible As Int32 = 1
    Public Const wsModelWindowMaximised As Int32 = 2
    Public Const wsModelWindowMinimised As Int32 = 3
    Public Const wsModelWindowHidden As Int32 = 4

    Rem Entity Display Settings - Node
    Public Const ipNodeSelectedColour As Int32 = 0
    Public Const ipNodeUnselectedColour As Int32 = 1
    Public Const ipNodeShowFree As Int32 = 2
    Public Const ipNodeNumberMode As Int32 = 3
    Public Const ipNodeSymbol As Int32 = 4

    Rem Entity Display Settings - Beam
    Public Const ipBeamDisplay As Int32 = 0
    Public Const ipBeamShowRefNode As Int32 = 1
    Public Const ipBeamShowOffset As Int32 = 2
    Public Const ipBeamMoveToOffset As Int32 = 3
    Public Const ipBeamLightShade As Int32 = 4
    Public Const ipBeamGlobalColour As Int32 = 5
    Public Const ipBeamOutlineColour As Int32 = 6
    Public Const ipBeamEnd1Colour As Int32 = 7
    Public Const ipBeamEnd2Colour As Int32 = 8
    Public Const ipBeamRefNodeColour As Int32 = 9
    Public Const ipBeamFilledMode As Int32 = 10
    Public Const ipBeamContour As Int32 = 11
    Public Const ipBeamShrink As Int32 = 12
    Public Const ipBeamRoundFacets As Int32 = 13
    Public Const ipBeamSpringCoils As Int32 = 14
    Public Const ipBeamSpringAspect As Int32 = 15
    Public Const ipBeamThickness As Int32 = 16
    Public Const ipBeamSections As Int32 = 17
    Public Const ipBeamOutlines As Int32 = 18
    Public Const ipBeamShowAxes As Int32 = 19
    Public Const ipBeamNumberMode As Int32 = 20

    Rem Entity Display Settings - Plate
    Public Const ipPlateDisplay As Int32 = 0
    Public Const ipPlateLightShade As Int32 = 1
    Public Const ipPlateGlobalColour As Int32 = 2
    Public Const ipPlateOutlineColour As Int32 = 3
    Public Const ipPlateZPlusColour As Int32 = 4
    Public Const ipPlateZMinusColour As Int32 = 5
    Public Const ipPlateOffsetColour As Int32 = 6
    Public Const ipPlateFilledMode As Int32 = 7
    Public Const ipPlateContour As Int32 = 8
    Public Const ipPlateShrink As Int32 = 9
    Public Const ipPlateOutlines As Int32 = 10
    Public Const ipPlateOutlineThickness As Int32 = 11
    Public Const ipPlateShowAxes As Int32 = 12
    Public Const ipPlateAxisOnPly As Int32 = 13
    Public Const ipPlateOffset As Int32 = 14
    Public Const ipPlateMoveToOffset As Int32 = 15
    Public Const ipPlateNumberMode As Int32 = 16

    Rem Entity Display Settings - Brick
    Public Const ipBrickLightShade As Int32 = 0
    Public Const ipBrickGlobalColour As Int32 = 1
    Public Const ipBrickOutlineColour As Int32 = 2
    Public Const ipBrickFilledMode As Int32 = 3
    Public Const ipBrickContour As Int32 = 4
    Public Const ipBrickShrink As Int32 = 5
    Public Const ipBrickOutlines As Int32 = 6
    Public Const ipBrickOutlineThickness As Int32 = 7
    Public Const ipBrickShowFreeFaces As Int32 = 8
    Public Const ipBrickAxes1 As Int32 = 9
    Public Const ipBrickAxes2 As Int32 = 10
    Public Const ipBrickAxes3 As Int32 = 11
    Public Const ipBrickNumberMode As Int32 = 12
    Public Const ipBrickShowAllFaces As Int32 = 13

    Rem Entity Display Settings - Link
    Public Const ipLinkGlobalColour As Int32 = 0
    Public Const ipLinkMasterSlaveColour As Int32 = 1
    Public Const ipLinkSectorSymmColour As Int32 = 2
    Public Const ipLinkCouplingColour As Int32 = 3
    Public Const ipLinkPinnedColour As Int32 = 4
    Public Const ipLinkRigidColour As Int32 = 5
    Public Const ipLinkShrinkColour As Int32 = 6
    Public Const ipLinkTwoPointColour As Int32 = 7
    Public Const ipLinkAttachmentColour As Int32 = 8
    Public Const ipLinkMultiPointColour As Int32 = 9
    Public Const ipLinkFilledMode As Int32 = 10
    Public Const ipLinkNumberMode As Int32 = 11

    Rem Entity Display Settings - Load Path
    Public Const ipLoadPathColour As Int32 = 0
    Public Const ipLoadPathColourMode As Int32 = 1
    Public Const ipLoadPathNumberMode As Int32 = 2
    Public Const ipLoadPathShowDivisions As Int32 = 3
    Public Const ipLoadPathThickness As Int32 = 4

    Rem Entity Display Settings - Vertex
    Public Const ipVertexFreeColour As Int32 = 0
    Public Const ipVertexFixedColour As Int32 = 1
    Public Const ipVertexSelectedColour As Int32 = 2
    Public Const ipVertextNumberMode As Int32 = 3
    Public Const ipVertexSymbol As Int32 = 4

    Rem Entity Display Settings - Geometry Edge
    Public Const ipEdgeShow As Int32 = 0
    Public Const ipEdgeShowNonInterp As Int32 = 1
    Public Const ipEdgeStyle As Int32 = 2
    Public Const ipEdgeColourMode As Int32 = 3
    Public Const ipEdgeColour As Int32 = 4
    Public Const ipEdgeNonInterpColour As Int32 = 5

    Rem Entity Display Settings - Geometry Face
    Public Const ipFaceWireframeColour As Int32 = 0
    Public Const ipFaceShowWireframes As Int32 = 1
    Public Const ipFaceShowControlPoints As Int32 = 2
    Public Const ipFaceShowNormals As Int32 = 3
    Public Const ipFaceWireframeStyle As Int32 = 4
    Public Const ipFaceWireframeColourMode As Int32 = 5
    Public Const ipFaceWireframeDensity As Int32 = 6

    Rem Entity Display Settings - Number Modes
    Public Const nmNone As Int32 = 0
    Public Const nmByElement As Int32 = 1
    Public Const nmByProperty As Int32 = 2
    Public Const nmByPropertyName As Int32 = 3
    Public Const nmByID As Int32 = 4

    Rem Entity Display Settings - Display Modes
    Public Const dmLine As Int32 = 0
    Public Const dmSection As Int32 = 1
    Public Const dmSolid As Int32 = 2
    Public Const dmSlice As Int32 = 3

    Rem Entity Display Settings - Outline Modes
    Public Const omOutlineOn As Int32 = 0
    Public Const omOutlineOff As Int32 = 1
    Public Const omOutlineFacet As Int32 = 2

    Rem Entity Display Settings - Filled Modes
    Public Const fmPropertyColour As Int32 = 1
    Public Const fmGroupColour As Int32 = 2
    Public Const fmGlobalColour As Int32 = 3
    Public Const fmPropertyWireframe As Int32 = 4
    Public Const fmGroupWireframe As Int32 = 5
    Public Const fmOutlineWireframe As Int32 = 6
    Public Const fmOrientation As Int32 = 7

    Rem Entity Display Settings - Colour Modes
    Public Const cmPropertyColour As Int32 = 0
    Public Const cmGroupColour As Int32 = 1
    Public Const cmFaceColour As Int32 = 2
    Public Const cmFixedColour As Int32 = 3

    Rem Entity Display Settings - Load Path Colour Modes
    Public Const cmLoadPathTemplateColour As Int32 = 0
    Public Const cmLoadPathGroupColour As Int32 = 1
    Public Const cmLoadPathColour As Int32 = 2
    Public Const cmLoadPathGlobalColour As Int32 = 3

    Rem Entity Display Settings - Edge Styles
    Public Const esThinEdge As Int32 = 0
    Public Const esThickEdge As Int32 = 1

    Rem Entity Display Settings - Wireframe Styles
    Public Const wsDepthShaded As Int32 = 0
    Public Const wsConstantColour As Int32 = 1

    Rem Entity Display Settings - Node/Vertex Symbols
    Public Const syDot1 As Int32 = 0
    Public Const syDot2 As Int32 = 1
    Public Const syDot3 As Int32 = 2
    Public Const syDot4 As Int32 = 3
    Public Const sySquare1 As Int32 = 4
    Public Const sySquare2 As Int32 = 5
    Public Const syDisk1 As Int32 = 6
    Public Const syDisk2 As Int32 = 7
    Public Const syCircle1 As Int32 = 8
    Public Const syCircle2 As Int32 = 9
    Public Const syCircle3 As Int32 = 10
    Public Const sy3D1 As Int32 = 11
    Public Const sy3D2 As Int32 = 12
    Public Const sy3D3 As Int32 = 13

    Rem Entity Display Settings - Beam Contour Types
    Public Const ctBeamNone As Int32 = 0
    Public Const ctBeamLength As Int32 = 1
    Public Const ctBeamAxis1 As Int32 = 2
    Public Const ctBeamAxis2 As Int32 = 3
    Public Const ctBeamAxis3 As Int32 = 4
    Public Const ctBeamEA As Int32 = 5
    Public Const ctBeamEI11 As Int32 = 6
    Public Const ctBeamEI22 As Int32 = 7
    Public Const ctBeamGJ As Int32 = 8
    Public Const ctBeamEAFactor As Int32 = 9
    Public Const ctBeamEI11Factor As Int32 = 10
    Public Const ctBeamEI22Factor As Int32 = 11
    Public Const ctBeamGJFactor As Int32 = 12
    Public Const ctBeamOffset1 As Int32 = 13
    Public Const ctBeamOffset2 As Int32 = 14
    Public Const ctBeamStiffnessFactor1 As Int32 = 15
    Public Const ctBeamStiffnessFactor2 As Int32 = 16
    Public Const ctBeamStiffnessFactor3 As Int32 = 17
    Public Const ctBeamStiffnessFactor4 As Int32 = 18
    Public Const ctBeamStiffnessFactor5 As Int32 = 19
    Public Const ctBeamStiffnessFactor6 As Int32 = 20
    Public Const ctBeamMassFactor As Int32 = 21
    Public Const ctBeamSupport1 As Int32 = 22
    Public Const ctBeamSupport2 As Int32 = 23
    Public Const ctBeamTemperature As Int32 = 24
    Public Const ctBeamPreTension As Int32 = 25
    Public Const ctBeamPreStrain As Int32 = 26
    Public Const ctBeamTempGradient1 As Int32 = 27
    Public Const ctBeamTempGradient2 As Int32 = 28
    Public Const ctBeamPipePressureIn As Int32 = 29
    Public Const ctBeamPipePressureOut As Int32 = 30
    Public Const ctBeamPipeTempIn As Int32 = 31
    Public Const ctBeamPipeTempOut As Int32 = 32
    Public Const ctBeamConvectionCoeff As Int32 = 33
    Public Const ctBeamConvectionAmbient As Int32 = 34
    Public Const ctBeamRadiationCoeff As Int32 = 35
    Public Const ctBeamRadiationAmbient As Int32 = 36
    Public Const ctBeamHeatFlux As Int32 = 37
    Public Const ctBeamHeatSource As Int32 = 38
    Public Const ctBeamAgeAtFirstLoading As Int32 = 39

    Rem Entity Display Settings - Plate Contour Types
    Public Const ctPlateNone As Int32 = 0
    Public Const ctPlateAspectRatioMin As Int32 = 1
    Public Const ctPlateAspectRatioMax As Int32 = 2
    Public Const ctPlateWarping As Int32 = 3
    Public Const ctPlateInternalAngle As Int32 = 4
    Public Const ctPlateInternalAngleRatio As Int32 = 5
    Public Const ctPlateDiscreteThicknessM As Int32 = 6
    Public Const ctPlateContinuousThicknessM As Int32 = 7
    Public Const ctPlateDiscreteThicknessB As Int32 = 8
    Public Const ctPlateContinuousThicknessB As Int32 = 9
    Public Const ctPlateOffset As Int32 = 10
    Public Const ctPlateArea As Int32 = 11
    Public Const ctPlateAxis1 As Int32 = 12
    Public Const ctPlateAxis2 As Int32 = 13
    Public Const ctPlateAxis3 As Int32 = 14
    Public Const ctPlateTemperature As Int32 = 15
    Public Const ctPlateEdgeSupport As Int32 = 16
    Public Const ctPlateFaceSupport As Int32 = 17
    Public Const ctPlatePreStressX As Int32 = 18
    Public Const ctPlatePreStressY As Int32 = 19
    Public Const ctPlatePresStressZ As Int32 = 20
    Public Const ctPlatePreStressMagnitude As Int32 = 21
    Public Const ctPlatePreStrainX As Int32 = 22
    Public Const ctPlatePreStrainY As Int32 = 23
    Public Const ctPlatePreStrainZ As Int32 = 24
    Public Const ctPlatePreStrainMagnitude As Int32 = 25
    Public Const ctPlateTempGradient As Int32 = 26
    Public Const ctPlateEdgePressure As Int32 = 27
    Public Const ctPlateEdgeShear As Int32 = 28
    Public Const ctPlateEdgeNormalShear As Int32 = 29
    Public Const ctPlatePressureNormal As Int32 = 30
    Public Const ctPlatePressureGlobal As Int32 = 31
    Public Const ctPlatePressureGlobalX As Int32 = 32
    Public Const ctPlatePressureGlobalY As Int32 = 33
    Public Const ctPlatePressureGlobalZ As Int32 = 34
    Public Const ctPlateFaceShearX As Int32 = 35
    Public Const ctPlateFaceShearY As Int32 = 36
    Public Const ctPlateFaceShearMagnitude As Int32 = 37
    Public Const ctPlateNSMass As Int32 = 38
    Public Const ctPlateDynamicFactor As Int32 = 39
    Public Const ctPlateConvectionCoeff As Int32 = 40
    Public Const ctPlateConvectionAmbient As Int32 = 41
    Public Const ctPlateRadiationCoeff As Int32 = 42
    Public Const ctPlateRadiationAmbient As Int32 = 43
    Public Const ctPlateHeatFlux As Int32 = 44
    Public Const ctPlateConvectionCoeffZPlus As Int32 = 45
    Public Const ctPlateConvectionCoeffZMinus As Int32 = 46
    Public Const ctPlateConvectionAmbientZPlus As Int32 = 47
    Public Const ctPlateConvectionAmbientZMinus As Int32 = 48
    Public Const ctPlateRadiationCoeffZPlus As Int32 = 49
    Public Const ctPlateRadiationCoeffZMinus As Int32 = 50
    Public Const ctPlateRadiationAmbientZPlus As Int32 = 51
    Public Const ctPlateRadiationAmbientZMinus As Int32 = 52
    Public Const ctPlateHeatSource As Int32 = 53
    Public Const ctPlateSoilStressSV As Int32 = 54
    Public Const ctPlateSoilStressKO As Int32 = 55
    Public Const ctPlateSoilStressSH As Int32 = 56
    Public Const ctPlateSoilRatioOCR As Int32 = 57
    Public Const ctPlateSoilRatioEO As Int32 = 58
    Public Const ctPlateAgeAtFirstLoading As Int32 = 59

    Rem Entity Display Settings - Brick Contour Types
    Public Const ctBrickNone As Int32 = 0
    Public Const ctBrickAspectRatioMin As Int32 = 1
    Public Const ctBrickAspectRatioMax As Int32 = 2
    Public Const ctBrickVolume As Int32 = 3
    Public Const ctBrickDeterminant As Int32 = 4
    Public Const ctBrickInternalAngle As Int32 = 5
    Public Const ctBrickMixedProduct As Int32 = 6
    Public Const ctBrickDihedral As Int32 = 7
    Public Const ctBrickAxis1 As Int32 = 8
    Public Const ctBrickAxis2 As Int32 = 9
    Public Const ctBrickAxis3 As Int32 = 10
    Public Const ctBrickTemperature As Int32 = 11
    Public Const ctBrickSupport As Int32 = 12
    Public Const ctBrickPreStressX As Int32 = 13
    Public Const ctBrickPreStressY As Int32 = 14
    Public Const ctBrickPreStressZ As Int32 = 15
    Public Const ctBrickPreStressMagnitude As Int32 = 16
    Public Const ctBrickPreStrainX As Int32 = 17
    Public Const ctBrickPreStrainY As Int32 = 18
    Public Const ctBrickPreStrainZ As Int32 = 19
    Public Const ctBrickPreStrainMagnitude As Int32 = 20
    Public Const ctBrickNormalPressure As Int32 = 21
    Public Const ctBrickGlobalPressure As Int32 = 22
    Public Const ctBrickGlobalPressureX As Int32 = 23
    Public Const ctBrickGlobalPressureY As Int32 = 24
    Public Const ctBrickGlobalPressureZ As Int32 = 25
    Public Const ctBrickShearX As Int32 = 26
    Public Const ctBrickShearY As Int32 = 27
    Public Const ctBrickShearMagnitude As Int32 = 28
    Public Const ctBrickNSMass As Int32 = 29
    Public Const ctBrickDynamicFactor As Int32 = 30
    Public Const ctBrickConvectionCoeff As Int32 = 31
    Public Const ctBrickConvectionAmbient As Int32 = 32
    Public Const ctBrickRaditionCoeff As Int32 = 33
    Public Const ctBrickRadiationAmbient As Int32 = 34
    Public Const ctBrickHeatFlux As Int32 = 35
    Public Const ctBrickHeatSource As Int32 = 36
    Public Const ctBrickSoilStressSV As Int32 = 37
    Public Const ctBrickSoilStressKO As Int32 = 38
    Public Const ctBrickSoilStressSH As Int32 = 39
    Public Const ctBrickSoilRatioOCR As Int32 = 40
    Public Const ctBrickSoilRatioEO As Int32 = 41
    Public Const ctBrickAgeAtFirstLoading As Int32 = 42

    Rem Beam/Plate/Brick Result Display Type - INDEXED BY ipResultType
    Public Const rtAsNone As Int32 = 0
    Public Const rtAsContour As Int32 = 1
    Public Const rtAsDiagram As Int32 = 2
    Public Const rtAsVector As Int32 = 3

    Rem Node Output Display Quantity - Indexed by ipResultQuantity
    Public Const icDispC As Int32 = 101
    Public Const icVelC As Int32 = 102
    Public Const icAccC As Int32 = 103
    Public Const icPhaseC As Int32 = 104
    Public Const icReactC As Int32 = 105
    Public Const icTempC As Int32 = 106
    Public Const icNodeForceC As Int32 = 107
    Public Const icNodeFluxC As Int32 = 108

    Rem Beam Output Display Quantity - Indexed by ipResultQuantity
    Public Const icBeamForceC As Int32 = 201
    Public Const icBeamStrainC As Int32 = 202
    Public Const icBeamStressC As Int32 = 203
    Public Const icBeamCreepStrainC As Int32 = 204
    Public Const icBeamEnergyC As Int32 = 205
    Public Const icBeamFluxC As Int32 = 206
    Public Const icBeamTGradC As Int32 = 207

    Rem Plate Output Display Quantity - Indexed by ipResultQuantity
    Public Const icPlateForceC As Int32 = 301
    Public Const icPlateMomentC As Int32 = 302
    Public Const icPlateStressC As Int32 = 303
    Public Const icPlateStrainC As Int32 = 304
    Public Const icPlateCurvatureC As Int32 = 305
    Public Const icPlateCreepStrainC As Int32 = 306
    Public Const icPlateEnergyC As Int32 = 307
    Public Const icPlateFluxC As Int32 = 308
    Public Const icPlateTGradC As Int32 = 309

    Rem Brick Output Display Quantity - Indexed by ipResultQuantity
    Public Const icBrickStressC As Int32 = 401
    Public Const icBrickStrainC As Int32 = 402
    Public Const icBrickCreepStrainC As Int32 = 403
    Public Const icBrickEnergyC As Int32 = 404
    Public Const icBrickFluxC As Int32 = 405
    Public Const icBrickTGradC As Int32 = 406

    Rem Vector Styles - Indexed by ipVectorStyle
    Public Const vtVectorComponent As Int32 = 0
    Public Const vtVectorTranslationMag As Int32 = 1
    Public Const vtVectorRotationMag As Int32 = 2

    Rem Result Display Indexes
    Public Const ipResultType As Int32 = 0
    Public Const ipResultQuantity As Int32 = 1
    Public Const ipResultAxis As Int32 = 2
    Public Const ipResultComponent As Int32 = 3
    Public Const ipResultSurface As Int32 = 4
    Public Const ipVectorStyle As Int32 = 5
    Public Const ipDiagram1 As Int32 = 7
    Public Const ipDiagram2 As Int32 = 8
    Public Const ipDiagram3 As Int32 = 9
    Public Const ipDiagram4 As Int32 = 10
    Public Const ipDiagram5 As Int32 = 11
    Public Const ipDiagram6 As Int32 = 12
    Public Const ipVector1 As Int32 = 7
    Public Const ipVector2 As Int32 = 8
    Public Const ipVector3 As Int32 = 9
    Public Const ipVector4 As Int32 = 10
    Public Const ipVector5 As Int32 = 11
    Public Const ipVector6 As Int32 = 12

    Rem Displacement Scales
    Public Const dsPercent As Int32 = 0
    Public Const dsAbsolute As Int32 = 1

    Rem User Contour File Types
    Public Const ucNode As Int32 = 0
    Public Const ucElement As Int32 = 1

    Rem Utility
    Public Const ipRadian As Int32 = 0
    Public Const ipDegree As Int32 = 1

    Rem Result Options
    Public Const ipResOptsBeamEnvelope As Int32 = 0
    Public Const ipResOptsRotationUnit As Int32 = 1
    Public Const ipResOptsHRADisplacement As Int32 = 2
    Public Const ipResOptsHRAVelocity As Int32 = 3
    Public Const ipResOptsHRAAcceleration As Int32 = 4
    Public Const ipResOptsStageDisplacement As Int32 = 5
    Public Const ipResOptsStrainUnit As Int32 = 6

    Rem Result Options - Strain Units
    Public Const suUnit As Int32 = 0
    Public Const suPercent As Int32 = 1
    Public Const suMicro As Int32 = 2

    Rem Result Options - HRA
    Public Const hrRelative As Int32 = 0
    Public Const hrTotal As Int32 = 1

    Rem Result Options - Staging
    Public Const sdBirthStage As Int32 = 0
    Public Const sdInitial As Int32 = 1

    Rem Result Options - Beam Envelopes
    Public Const bePrincipal As Int32 = 0
    Public Const beLocal As Int32 = 1

    Rem Tool Options - Doubles
    Public Const ipToolOptsElementTol As Int32 = 0
    Public Const ipToolOptsGeometryAccuracy As Int32 = 1
    Public Const ipToolOptsGeometryFeatureLength As Int32 = 2

    Rem Tool Options - Integers
    Public Const ipToolOptsElementTolType As Int32 = 0
    Public Const ipToolOptsGeometryAccuracyType As Int32 = 1
    Public Const ipToolOptsGeometryFeatureType As Int32 = 2
    Public Const ipToolOptsZipMesh As Int32 = 3
    Public Const ipToolOptsNodeCoordinate As Int32 = 4
    Public Const ipToolOptsNodeAttributeKeep As Int32 = 5
    Public Const ipToolOptsAllowZeroLengthLinks As Int32 = 6
    Public Const ipToolOptsAllowZeroLengthBeams As Int32 = 7
    Public Const ipToolOptsAllowSameProperty As Int32 = 8
    Public Const ipToolOptsCompatibleTriangle As Int32 = 9
    Public Const ipToolOptsSubdivideBeams As Int32 = 10
    Public Const ipToolOptsPlateAxisAlign As Int32 = 11
    Public Const ipToolOptsCopyMode As Int32 = 12
    Public Const ipToolOptsAutoCreateProperties As Int32 = 13

    Rem Tool Options - Mesh Zipping
    Public Const zmAsNeeded As Int32 = 0
    Public Const zmOnSave As Int32 = 1
    Public Const zmOnRequest As Int32 = 2

    Rem Tool Options - Copy Mode
    Public Const cmRoot As Int32 = 0
    Public Const cmSibling As Int32 = 1

    Rem Tool Options - Axis Alignment
    Public Const paCentroid As Int32 = 0
    Public Const paCurvilinear As Int32 = 1

    Rem Axis Definitions
    Public Const axLocalX As Int32 = 1
    Public Const axLocalY As Int32 = 2
    Public Const axPrincipal1 As Int32 = 1
    Public Const axPrincipal2 As Int32 = 2
    Public Const axBeamPrincipal As Int32 = 0
    Public Const axBeamLocal As Int32 = 1

    Rem Beam Taper
    Public Const btSymm As Int32 = 0
    Public Const btTop As Int32 = 1
    Public Const btBottom As Int32 = 2

    Rem Pre-load
    Public Const plBeamPreTension As Int32 = 0
    Public Const plBeamPreStrain As Int32 = 1
    Public Const plPlatePreStress As Int32 = 0
    Public Const plPlatePreStrain As Int32 = 1
    Public Const plBrickPreStress As Int32 = 0
    Public Const plBrickPreStrain As Int32 = 1

    Rem Attachment Attribute
    Public Const alRigid As Int32 = 0
    Public Const alFlexible As Int32 = 1
    Public Const alDirect As Int32 = 2
    Public Const alMoment As Int32 = 0
    Public Const alPinned As Int32 = 1

    Rem Thermal
    Public Const ipConvection As Int32 = 0
    Public Const ipRadiation As Int32 = 0
    Public Const ipAmbient As Int32 = 1

    Rem LTA Methods
    Public Const ltWilson As Int32 = 0
    Public Const ltNewmark As Int32 = 1

    Rem Spectral
    Public Const stResponse As Int32 = 0
    Public Const stPSD As Int32 = 1

    Rem Spectral Results Sign
    Public Const rsAuto As Int32 = 0
    Public Const rsAbsolute As Int32 = 1

    Rem LTA
    Public Const stFullSystem As Int32 = 0
    Public Const stSuperposition As Int32 = 1

    Rem Attach Parts
    Public Const ipDoEnds As Int32 = 0
    Public Const ipDoEdges As Int32 = 1
    Public Const ipDoFaces As Int32 = 2
    Public Const ipSelectedOnly As Int32 = 3
    Public Const ipDeleteExisting As Int32 = 4
    Public Const ipAllBrickFaces As Int32 = 5
    Public Const ipAngleDelta As Int32 = 0

    Rem Modal Reactions
    Public Const mrElementForce As Int32 = 0
    Public Const mrInertiaForce As Int32 = 1

    Rem Transient Initial Conditions
    Public Const icAppliedVectors As Int32 = 0
    Public Const icNodalVelocity As Int32 = 1
    Public Const icFromFile As Int32 = 2

    Rem Transient-Quasi Temperature
    Public Const ttNodalTemp As Int32 = 0
    Public Const ttFromFile As Int32 = 1

    Rem Envelopes
    Public Const etLimitEnvelopeMin As Int32 = 0
    Public Const etLimitEnvelopeMax As Int32 = 1
    Public Const etLimitEnvelopeAbs As Int32 = 2
    Public Const etCombEnvelopeMin As Int32 = 3
    Public Const etCombEnvelopeMax As Int32 = 4
    Public Const etFactEnvelopeMin As Int32 = 5
    Public Const etFactEnvelopeMax As Int32 = 6
    Public Const esCombEnvelopeOn As Int32 = 0
    Public Const esCombEnvelopeOff As Int32 = 1
    Public Const esCombEnvelopeCheck As Int32 = 2
    Public Const stExclusiveOR As Int32 = 0
    Public Const stExclusiveAND As Int32 = 1

    Rem Frequency Table Units
    Public Const fuNone As Int32 = 0
    Public Const fuDispResponse As Int32 = 1
    Public Const fuVelResponse As Int32 = 2
    Public Const fuAccelResponse As Int32 = 3
    Public Const fuDispPSD As Int32 = 4
    Public Const fuVelPSD As Int32 = 5
    Public Const fuAccelPSD As Int32 = 6

    Rem Temp/Time Types
    Public Const mtElastic As Int32 = 0
    Public Const mtPlastic As Int32 = 1

    Rem Material Hardening Types
    Public Const htIsotropic As Int32 = 0
    Public Const htKinematic As Int32 = 1
    Public Const htTakeda As Int32 = 2

    Rem Spring-damper
    Public Const ipSpringAxialStiff As Int32 = 0
    Public Const ipSpringLateralStiff As Int32 = 1
    Public Const ipSpringTorsionStiff As Int32 = 2
    Public Const ipSpringAxialDamp As Int32 = 3
    Public Const ipSpringLateralDamp As Int32 = 4
    Public Const ipSpringTorsionDamp As Int32 = 5
    Public Const ipSpringMass As Int32 = 6

    Rem Truss
    Public Const ipTrussIncludeTorsion As Int32 = 0

    Rem Cable
    Public Const ipCableSegments As Int32 = 0

    Rem Cutoff Bar
    Public Const ipCutoffTension As Int32 = 0
    Public Const ipCutoffCompression As Int32 = 1

    Rem Contact
    Public Const cfElastic As Int32 = 0
    Public Const cfPlastic As Int32 = 1
    Public Const cyRectangular As Int32 = 0
    Public Const cyElliptical As Int32 = 1

    Rem Ply Material - Integers
    Public Const ipPlyWeaveType As Int32 = 0
    Public Const wtPlyUniDirectional As Int32 = 0
    Public Const wtPlyBiDirectional As Int32 = 1
    Public Const wtPlyTriDirectional As Int32 = 2
    Public Const wtPlyQuasiIsotropic As Int32 = 3

    Rem Ply Material - Doubles
    Public Const ipPlyModulus1 As Int32 = 0
    Public Const ipPlyModulus2 As Int32 = 1
    Public Const ipPlyPoisson As Int32 = 2
    Public Const ipPlyShear12 As Int32 = 3
    Public Const ipPlyShear13 As Int32 = 4
    Public Const ipPlyShear23 As Int32 = 5
    Public Const ipPlyAlpha1 As Int32 = 6
    Public Const ipPlyAlpha2 As Int32 = 7
    Public Const ipPlyDensity As Int32 = 8
    Public Const ipPlyThickness As Int32 = 9
    Public Const ipPlyS1Tension As Int32 = 10
    Public Const ipPlyS2Tension As Int32 = 11
    Public Const ipPlyS1Compression As Int32 = 12
    Public Const ipPlyS2Compression As Int32 = 13
    Public Const ipPlySShear As Int32 = 14
    Public Const ipPlyE1Tension As Int32 = 15
    Public Const ipPlyE2Tension As Int32 = 16
    Public Const ipPlyE1Compression As Int32 = 17
    Public Const ipPlyE2Compression As Int32 = 18
    Public Const ipPlyEShear As Int32 = 19
    Public Const ipPlyInterLaminaShear As Int32 = 20

    Rem Laminate Material
    Public Const ipLaminateViscosity As Int32 = 0
    Public Const ipLaminateDampingRatio As Int32 = 1
    Public Const ipLaminateConductivity1 As Int32 = 2
    Public Const ipLaminateConductivity2 As Int32 = 3
    Public Const ipLaminateSpecificHeat As Int32 = 4
    Public Const ipLaminateDensity As Int32 = 5
    Public Const ipLaminateAlphax As Int32 = 6
    Public Const ipLaminateAlphay As Int32 = 7
    Public Const ipLaminateAlphaxy As Int32 = 8
    Public Const ipLaminateBetax As Int32 = 9
    Public Const ipLaminateBetay As Int32 = 10
    Public Const ipLaminateBetaxy As Int32 = 11
    Public Const ipLaminateModulusx As Int32 = 12
    Public Const ipLaminateModulusy As Int32 = 13
    Public Const ipLaminateShearxy As Int32 = 14
    Public Const ipLaminatePoissonxy As Int32 = 15
    Public Const ipLaminatePoissonyx As Int32 = 16
    Public Const ipLaminateThickness As Int32 = 17

    Rem Laminate Plies
    Public Const ipLaminatePlyAngle As Int32 = 0
    Public Const ipLaminatePlyThickness As Int32 = 1

    Rem Laminate Matrices
    Public Const ipLaminateIgnoreCoupling As Int32 = 0
    Public Const ipLaminateAutoTransverseShear As Int32 = 1

    Rem Concrete Reinforcement Layouts - Integers
    Public Const ipReoLayoutType As Int32 = 0
    Public Const ipReoColour13 As Int32 = 1
    Public Const ipReoColour24 As Int32 = 2
    Public Const ipReoCalcMethod As Int32 = 3
    Public Const ipReoConsiderMembrane As Int32 = 4
    Public Const ipReoAllowCompressionReo As Int32 = 5
    Public Const ipReoCode As Int32 = 6
    Public Const ipReoLimitConcreteStrain As Int32 = 7
    Public Const crReoSymmetric As Int32 = 0
    Public Const crReoAntiSymmetric As Int32 = 1
    Public Const crReoSimplified As Int32 = 0
    Public Const crReoElastoPlasticIter As Int32 = 1

    Rem Concrete Reinforcement Layouts - Doubles
    Public Const ipReoDiam1 As Int32 = 0
    Public Const ipReoDiam2 As Int32 = 1
    Public Const ipReoDiam3 As Int32 = 2
    Public Const ipReoDiam4 As Int32 = 3
    Public Const ipReoCover1 As Int32 = 4
    Public Const ipReoCover2 As Int32 = 5
    Public Const ipReoSpacing1 As Int32 = 6
    Public Const ipReoSpacing2 As Int32 = 7
    Public Const ipReoSpacing3 As Int32 = 8
    Public Const ipReoSpacing4 As Int32 = 9
    Public Const ipReoConcreteModulus As Int32 = 10
    Public Const ipReoConcreteStrain As Int32 = 11
    Public Const ipReoConcreteStress As Int32 = 12
    Public Const ipReoConcretePhi As Int32 = 13
    Public Const ipReoConcreteGamma As Int32 = 14
    Public Const ipReoSteelModulus As Int32 = 15
    Public Const ipReoSteelStress As Int32 = 16
    Public Const ipReoSteelGamma As Int32 = 17
    Public Const ipReoSteelMinArea As Int32 = 18

    Rem Creep Hardening
    Public Const ipCreepHardeningType As Int32 = 0
    Public Const ipCreepHardeningCyclic As Int32 = 1
    Public Const crHardeningTime As Int32 = 0
    Public Const crHardeningStrain As Int32 = 1

    Rem Hyperbolic Creep - Doubles
    Public Const ipCreepHyberbolicAlpha As Int32 = 0
    Public Const ipCreepHyperbolicBeta As Int32 = 1
    Public Const ipCreepHyperbolicDelta As Int32 = 2
    Public Const ipCreepHyperbolicPhi As Int32 = 3

    Rem Hyperbolic Creep - Integers
    Public Const ipCreepHyperbolicTimeTable As Int32 = 0
    Public Const ipCreepHyperbolicConstModulus As Int32 = 1

    Rem Visco-elastic Creep - Integers
    Public Const ipCreepViscoTimeTable As Int32 = 0
    Public Const ipCreepViscoTempTable As Int32 = 1

    Rem Visco-elastic Creep - Doubles
    Public Const ipCreepViscoDamper As Int32 = 0
    Public Const ipCreepViscoStiffness As Int32 = 1

    Rem Creep Concrete Functions
    Public Const cfCreepFunction As Int32 = 0
    Public Const cfRelaxationFunction As Int32 = 1

    Rem Creep Shrinkage
    Public Const crCreepShrinkageTable As Int32 = 0
    Public Const crCreepShrinkageFormula As Int32 = 1
    Public Const ipCreepShrinkageAlpha As Int32 = 0
    Public Const ipCreepShrinkageBeta As Int32 = 1
    Public Const ipCreepShrinkageDelta As Int32 = 2
    Public Const ipCreepShrinkageStrain As Int32 = 3

    Rem Creep Temperature - Integers
    Public Const ipIncludeCreepTemperature As Int32 = 0
    Public Const ipIncludeRateTemperature As Int32 = 1
    Public Const ipIncludeShrinkageTemperature As Int32 = 2

    Rem Creep Temperature - Doubles
    Public Const ipCreepCAAge As Int32 = 0
    Public Const ipCreepTRefAge As Int32 = 1
    Public Const ipCreepCCCreep As Int32 = 2
    Public Const ipCreepTRefCreep As Int32 = 3
    Public Const ipCreepCAShrink As Int32 = 4
    Public Const ipCreepTRefShrink As Int32 = 5

    Rem Cement Curing - Integers
    Public Const ipCreepIncludeCuring As Int32 = 0
    Public Const ipCreepCuringTimeTable As Int32 = 1
    Public Const ipCreepCuringType As Int32 = 2
    Public Const ctCuringRapid As Int32 = 0
    Public Const ctCuringNormal As Int32 = 1
    Public Const ctCuringSlow As Int32 = 2

    Rem Cement Curing - Doubles
    Public Const ipCreepCuringCT As Int32 = 0
    Public Const ipCreepCuringTRef As Int32 = 1
    Public Const ipCreepCuringT0 As Int32 = 2

    Rem Stage Data
    Public Const ipStageMorph As Int32 = 0
    Public Const ipStageMovedFixedNodes As Int32 = 1
    Public Const ipStageRotateClusters As Int32 = 2

    Rem Node Response Variables
    Public Const reNodeDisplacement As Int32 = 0
    Public Const reNodeReaction As Int32 = 1

    Rem Beam Response Variables
    Public Const ipBeamResponseSF1 As Int32 = 0
    Public Const ipBeamResponseSF2 As Int32 = 1
    Public Const ipBeamResponseAxial As Int32 = 2
    Public Const ipBeamResponseBM1 As Int32 = 3
    Public Const ipBeamResponseBM2 As Int32 = 4
    Public Const ipBeamResponseTorque As Int32 = 5

    Rem Plate Response Variables
    Public Const rePlateForce As Int32 = 0
    Public Const rePlateMoment As Int32 = 1

    Rem Pipe Properties
    Public Const ipPipeFlexibility As Int32 = 0
    Public Const ipPipeFluidDensity As Int32 = 1
    Public Const ipPipeOuterDiameter As Int32 = 2
    Public Const ipPipeThickness As Int32 = 3

    Rem Connection Properties
    Public Const ipConnectionShear1 As Int32 = 0
    Public Const ipConnectionShear2 As Int32 = 1
    Public Const ipConnectionAxial As Int32 = 2
    Public Const ipConnectionBend1 As Int32 = 3
    Public Const ipConnectionBend2 As Int32 = 4
    Public Const ipConnectionTorque As Int32 = 5

    Rem Beam Materials
    Public Const ipBeamModulus As Int32 = 0
    Public Const ipBeamShear As Int32 = 1
    Public Const ipBeamPoisson As Int32 = 2
    Public Const ipBeamDensity As Int32 = 3
    Public Const ipBeamAlpha As Int32 = 4
    Public Const ipBeamViscosity As Int32 = 5
    Public Const ipBeamDampingRatio As Int32 = 6
    Public Const ipBeamConductivity As Int32 = 7
    Public Const ipBeamSpecificHeat As Int32 = 8

    Rem Plate Isotropic Materials
    Public Const ipPlateIsoModulus As Int32 = 0
    Public Const ipPlateIsoPoisson As Int32 = 1
    Public Const ipPlateIsoDensity As Int32 = 2
    Public Const ipPlateIsoAlpha As Int32 = 3
    Public Const ipPlateIsoViscosity As Int32 = 4
    Public Const ipPlateIsoDampingRatio As Int32 = 5
    Public Const ipPlateIsoConductivity As Int32 = 6
    Public Const ipPlateIsoSpecificHeat As Int32 = 7

    Rem Brick Isotropic Materials
    Public Const ipBrickIsoModulus As Int32 = 0
    Public Const ipBrickIsoPoisson As Int32 = 1
    Public Const ipBrickIsoDensity As Int32 = 2
    Public Const ipBrickIsoAlpha As Int32 = 3
    Public Const ipBrickIsoViscosity As Int32 = 4
    Public Const ipBrickIsoDampingRatio As Int32 = 5
    Public Const ipBrickIsoConductivity As Int32 = 6
    Public Const ipBrickIsoSpecificHeat As Int32 = 7

    Rem Plate Orthotropic Materials
    Public Const ipPlateOrthoModulus1 As Int32 = 0
    Public Const ipPlateOrthoModulus2 As Int32 = 1
    Public Const ipPlateOrthoModulus3 As Int32 = 2
    Public Const ipPlateOrthoShear12 As Int32 = 3
    Public Const ipPlateOrthoShear23 As Int32 = 4
    Public Const ipPlateOrthoShear31 As Int32 = 5
    Public Const ipPlateOrthoPoisson12 As Int32 = 6
    Public Const ipPlateOrthoPoisson23 As Int32 = 7
    Public Const ipPlateOrthoPoisson31 As Int32 = 8
    Public Const ipPlateOrthoDensity As Int32 = 9
    Public Const ipPlateOrthoAlpha1 As Int32 = 10
    Public Const ipPlateOrthoAlpha2 As Int32 = 11
    Public Const ipPlateOrthoAlpha3 As Int32 = 12
    Public Const ipPlateOrthoViscosity As Int32 = 13
    Public Const ipPlateOrthoDampingRatio As Int32 = 14
    Public Const ipPlateOrthoConductivity1 As Int32 = 15
    Public Const ipPlateOrthoConductivity2 As Int32 = 16
    Public Const ipPlateOrthoSpecificHeat As Int32 = 17

    Rem Brick Orthotropic Materials
    Public Const ipBrickOrthoModulus1 As Int32 = 0
    Public Const ipBrickOrthoModulus2 As Int32 = 1
    Public Const ipBrickOrthoModulus3 As Int32 = 2
    Public Const ipBrickOrthoShear12 As Int32 = 3
    Public Const ipBrickOrthoShear23 As Int32 = 4
    Public Const ipBrickOrthoShear31 As Int32 = 5
    Public Const ipBrickOrthoPoisson12 As Int32 = 6
    Public Const ipBrickOrthoPoisson23 As Int32 = 7
    Public Const ipBrickOrthoPoisson31 As Int32 = 8
    Public Const ipBrickOrthoDensity As Int32 = 9
    Public Const ipBrickOrthoAlpha1 As Int32 = 10
    Public Const ipBrickOrthoAlpha2 As Int32 = 11
    Public Const ipBrickOrthoAlpha3 As Int32 = 12
    Public Const ipBrickOrthoViscosity As Int32 = 13
    Public Const ipBrickOrthoDampingRatio As Int32 = 14
    Public Const ipBrickOrthoConductivity1 As Int32 = 15
    Public Const ipBrickOrthoConductivity2 As Int32 = 16
    Public Const ipBrickOrthoConductivity3 As Int32 = 17
    Public Const ipBrickOrthoSpecificHeat As Int32 = 18

    Rem Plate Anisotropic Materials

    Rem 0..9 ansi matrix
    Public Const ipPlateAnisoTransShear1 As Int32 = 10
    Public Const ipPlateAnisoTransShear2 As Int32 = 11
    Public Const ipPlateAnisoTransShear3 As Int32 = 12
    Public Const ipPlateAnisoDensity As Int32 = 13
    Public Const ipPlateAnisoAlpha1 As Int32 = 14
    Public Const ipPlateAnisoAlpha2 As Int32 = 15
    Public Const ipPlateAnisoAlpha3 As Int32 = 16
    Public Const ipPlateAnisoAlpha12 As Int32 = 17
    Public Const ipPlateAnisoViscosity As Int32 = 18
    Public Const ipPlateAnisoDampingRatio As Int32 = 19
    Public Const ipPlateAnisoConductivity1 As Int32 = 20
    Public Const ipPlateAnisoConductivity2 As Int32 = 21
    Public Const ipPlateAnisoSpecificHeat As Int32 = 22

    Rem Plate User Defined Materials

    Rem 0..20 user matrix
    Public Const ipPlateUserTransShearxz As Int32 = 21
    Public Const ipPlateUserTransShearyz As Int32 = 22
    Public Const ipPlateUserTransShearcz As Int32 = 23
    Public Const ipPlateUserDensity As Int32 = 24
    Public Const ipPlateUserAlphax As Int32 = 25
    Public Const ipPlateUserAlphay As Int32 = 26
    Public Const ipPlateUserAlphaxy As Int32 = 27
    Public Const ipPlateUserBetax As Int32 = 28
    Public Const ipPlateUserBetay As Int32 = 29
    Public Const ipPlateUserBetaxy As Int32 = 30
    Public Const ipPlateUserViscosity As Int32 = 31
    Public Const ipPlateUserDampingRatio As Int32 = 32
    Public Const ipPlateUserConductivity1 As Int32 = 33
    Public Const ipPlateUserConductivity2 As Int32 = 34
    Public Const ipPlateUserSpecificHeat As Int32 = 35

    Rem Brick Anisotropic Materials

    Rem 0..20 user matrix
    Public Const ipBrickUserDensity As Int32 = 21
    Public Const ipBrickUserAlpha1 As Int32 = 22
    Public Const ipBrickUserAlpha2 As Int32 = 23
    Public Const ipBrickUserAlpha3 As Int32 = 24
    Public Const ipBrickUserAlpha12 As Int32 = 25
    Public Const ipBrickUserAlpha23 As Int32 = 26
    Public Const ipBrickUserAlpha31 As Int32 = 27
    Public Const ipBrickUserViscosity As Int32 = 28
    Public Const ipBrickUserDampingRatio As Int32 = 29
    Public Const ipBrickUserConductivity1 As Int32 = 30
    Public Const ipBrickUserConductivity2 As Int32 = 31
    Public Const ipBrickUserConductivity3 As Int32 = 32
    Public Const ipBrickUserSpecificHeat As Int32 = 33

    Rem Duncan-Chang Soil Materials - Integers
    Public Const ipSoilDCUsePoisson As Int32 = 0
    Public Const ipSoilDCSetLevel As Int32 = 1

    Rem Duncan-Chang Soil Materials - Doubles
    Public Const ipSoilDCModulusK As Int32 = 0
    Public Const ipSoilDCModulusKUR As Int32 = 1
    Public Const ipSoilDCModulusN As Int32 = 2
    Public Const ipSoilDCPoisson As Int32 = 3
    Public Const ipSoilDCBulkK As Int32 = 4
    Public Const ipSoilDCBulkM As Int32 = 5
    Public Const ipSoilDCFrictionAngle As Int32 = 6
    Public Const ipSoilDCDeltaAngle As Int32 = 7
    Public Const ipSoilDCCohesion As Int32 = 8
    Public Const ipSoilDCFailureRatio As Int32 = 9
    Public Const ipSoilDCFailureMod As Int32 = 10
    Public Const ipSoilDCReferenceP As Int32 = 11
    Public Const ipSoilDCDensity As Int32 = 12
    Public Const ipSoilDCHorizontalRatio As Int32 = 13
    Public Const ipSoilDCConductivity As Int32 = 14
    Public Const ipSoilDCSpecificHeat As Int32 = 15
    Public Const ipSoilDCFluidLevel As Int32 = 16

    Rem Cam-Clay Soil Materials - Integers
    Public Const ipSoilCCUsePoisson As Int32 = 0
    Public Const ipSoilCCDrainedState As Int32 = 1
    Public Const ipSoilCCUseOCR As Int32 = 2
    Public Const ipSoilCCSetLevel As Int32 = 3

    Rem Cam-Clay Soil Materials - Doubles
    Public Const ipSoilCCCriticalStateLine As Int32 = 0
    Public Const ipSoilCCConsolidationLine As Int32 = 1
    Public Const ipSoilCCSwellingLine As Int32 = 2
    Public Const ipSoilCCDensity As Int32 = 3
    Public Const ipSoilCCPoisson As Int32 = 4
    Public Const ipSoilCCModulusG As Int32 = 5
    Public Const ipSoilCCModulusB As Int32 = 6
    Public Const ipSoilCCHorizontalRatio As Int32 = 7
    Public Const ipSoilCCER As Int32 = 8
    Public Const ipSoilCCPR As Int32 = 9
    Public Const ipSoilCCPC0 As Int32 = 10
    Public Const ipSoilCCOCR As Int32 = 11
    Public Const ipSoilCCConductivity As Int32 = 12
    Public Const ipSoilCCSpecificHeat As Int32 = 13
    Public Const ipSoilCCFluidLevel As Int32 = 14

    Rem Mohr-Coulomb Soil Materials - Integers
    Public Const ipSoilMCSetLevel As Int32 = 0

    Rem Mohr-Coulomb Soil Materials - Doubles
    Public Const ipSoilMCModulus As Int32 = 0
    Public Const ipSoilMCPoisson As Int32 = 1
    Public Const ipSoilMCDensity As Int32 = 2
    Public Const ipSoilMCHorizontalRatio As Int32 = 3
    Public Const ipSoilMCER As Int32 = 4
    Public Const ipSoilMCConductivity As Int32 = 5
    Public Const ipSoilMCSpecificHeat As Int32 = 6
    Public Const ipSoilMCFluidLevel As Int32 = 7
    Public Const ipSoilMCCohesion As Int32 = 8
    Public Const ipSoilMCFrictionAngle As Int32 = 9

    Rem Drucker-Prager Soil Materials - Integers
    Public Const ipSoilDPSetLevel As Int32 = 0

    Rem Drucker-Prager Soil Materials - Doubles
    Public Const ipSoilDPModulus As Int32 = 0
    Public Const ipSoilDPPoisson As Int32 = 1
    Public Const ipSoilDPDensity As Int32 = 2
    Public Const ipSoilDPHorizontalRatio As Int32 = 3
    Public Const ipSoilDPER As Int32 = 4
    Public Const ipSoilDPConductivity As Int32 = 5
    Public Const ipSoilDPSpecificHeat As Int32 = 6
    Public Const ipSoilDPFluidLevel As Int32 = 7
    Public Const ipSoilDPCohesion As Int32 = 8
    Public Const ipSoilDPFrictionAngle As Int32 = 9

    Rem Linear Elastic Soil Materials - Integers
    Public Const ipSoilLSSetLevel As Int32 = 0

    Rem Linear Elastic Soil Materials - Doubles
    Public Const ipSoilLSModulus As Int32 = 0
    Public Const ipSoilLSPoisson As Int32 = 1
    Public Const ipSoilLSDensity As Int32 = 2
    Public Const ipSoilLSHorizontalRatio As Int32 = 3
    Public Const ipSoilLSER As Int32 = 4
    Public Const ipSoilLSConductivity As Int32 = 5
    Public Const ipSoilLSSpecificHeat As Int32 = 6
    Public Const ipSoilLSFluidLevel As Int32 = 7

    Rem Fluid Materials
    Public Const ipFluidModulus As Int32 = 0
    Public Const ipFluidPenaltyParam As Int32 = 1
    Public Const ipFluidDensity As Int32 = 2
    Public Const ipFluidAlpha As Int32 = 3
    Public Const ipFluidViscosity As Int32 = 4
    Public Const ipFluidDampingRatio As Int32 = 5
    Public Const ipFluidConductivity As Int32 = 6
    Public Const ipFluidSpecificHeat As Int32 = 7

    Rem Mohr-Coulomb, Drucker-Prager
    Public Const ipFrictionAngle As Int32 = 0
    Public Const ipCohesion As Int32 = 1

    Rem Rubber Materials
    Public Const ipRubberBulk As Int32 = 0
    Public Const ipRubberDensity As Int32 = 1
    Public Const ipRubberAlpha As Int32 = 2
    Public Const ipRubberViscosity As Int32 = 3
    Public Const ipRubberDampingRatio As Int32 = 4
    Public Const ipRubberConductivity As Int32 = 5
    Public Const ipRubberSpecificHeat As Int32 = 6
    Public Const ipRubberConstC1 As Int32 = 7

    Rem Load Case Types
    Public Const ltLoadCase As Int32 = 0
    Public Const ltSeismicCase As Int32 = 1
    Public Const ltSpectralCase As Int32 = 2

    Rem Polygon to Face - Doubles
    Public Const ipPolyToFaceEdgeTolerance As Int32 = 0

    Rem Polygon to Face - Integers
    Public Const ipPolyToFaceFaceID As Int32 = 0
    Public Const ipPolyToFaceGroupIndex As Int32 = 1
    Public Const ipPolyToFacePropertyNumber As Int32 = 2
    Public Const ipPolyToFaceDeleteBeams As Int32 = 3
    Public Const ipPolyToFaceKeepSelected As Int32 = 4

    Rem Beam Property
    Public Const ipBeamPropBeamType As Int32 = 0
    Public Const ipBeamPropSectionType As Int32 = 1
    Public Const ipBeamPropMirrorType As Int32 = 2
    Public Const ipBeamPropCompatibleTwist As Int32 = 3

    Rem Element Axis Types
    Public Const axUCS As Int32 = 0
    Public Const axLocal As Int32 = 1

    Rem Load Path Template - Integers
    Public Const ipLPTColour As Int32 = 0
    Public Const ipLPTNumLanes As Int32 = 1
    Public Const ipLPTMultiLaneType As Int32 = 2
    Public Const lpAllSameFactors As Int32 = 0
    Public Const lpAllDifferentFactors As Int32 = 1

    Rem Load Path Template - Doubles
    Public Const ipLPTTolerance As Int32 = 0
    Public Const ipLPTMinLaneWidth As Int32 = 1

    Rem Load Path Vehicle - Integers
    Public Const ipLPTVehicleInstance As Int32 = 0
    Public Const ipLPTVehicleDirection As Int32 = 1
    Public Const lpVehicleSingleLane As Int32 = 0
    Public Const lpVehicleDoubleLane As Int32 = 1
    Public Const lpVehicleForward As Int32 = 0
    Public Const lpVehicleBackward As Int32 = 1

    Rem Load Path Vehicle - Doubles
    Public Const ipLPTVehicleVelocity As Int32 = 0
    Public Const ipLPTVehicleStartTime As Int32 = 1

    Rem Load Path Template Forces - Integers
    Public Const ipLPTMobility As Int32 = 0
    Public Const ipLPTAxisSystem As Int32 = 1
    Public Const ipLPTAdjacency As Int32 = 2
    Public Const ipLPTCentrifugal As Int32 = 3
    Public Const lpPointForceMobilityGrouped As Int32 = 0
    Public Const lpPointForceMobilityFloating As Int32 = 1
    Public Const lpDistrForceMobilityGrouped As Int32 = 0
    Public Const lpDistrForceMobilityLeading As Int32 = 1
    Public Const lpDistrForceMobilityTrailing As Int32 = 2
    Public Const lpDistrForceMobilityFullLength As Int32 = 3
    Public Const lpDistrForceMobilityFloating As Int32 = 4
    Public Const lpAxisLocal As Int32 = 0
    Public Const lpAxisGlobal As Int32 = 1

    Rem Load Path Templates - Integers
    Public Const ipLPTLimitK1 As Int32 = 0
    Public Const ipLPTLengthUnit As Int32 = 1
    Public Const ipLPTForceUnit As Int32 = 2

    Rem Load Path Templates - Doubles
    Public Const ipLPTMinK1 As Int32 = 0
    Public Const ipLPTMaxK1 As Int32 = 1

    Rem Combined Result Files
    Public Const rfCombFactors As Int32 = 0
    Public Const rfCombSRSS As Int32 = 1

    Rem Load Path
    Public Const ipLoadPathCase As Int32 = 0
    Public Const ipLoadPathTemplate As Int32 = 1
    Public Const ipLoadPathShape As Int32 = 2
    Public Const ipLoadPathSurface As Int32 = 3
    Public Const ipLoadPathTarget As Int32 = 4
    Public Const ipLoadPathDivisions As Int32 = 5
    Public Const lpShapeStraight As Int32 = 0
    Public Const lpShapeCurved As Int32 = 1
    Public Const lpShapeQuadratic As Int32 = 2
    Public Const lpSurfaceFlat As Int32 = 0
    Public Const lpSurfaceCurved As Int32 = 1

    Rem Animation
    Public Const ipAniParentHandle As Int32 = 0
    Public Const ipAniCase As Int32 = 1
    Public Const ipNumFrames As Int32 = 2
    Public Const ipAniWidth As Int32 = 3
    Public Const ipAniHeight As Int32 = 4
    Public Const ipAniType As Int32 = 5
    Public Const kAniSAF As Int32 = 0
    Public Const kAniEXE As Int32 = 1
    Public Const kAniAVI As Int32 = 2

    Rem Custom Result Files - NODEDISP, NODEREACT
    Public Const ipNodeResFileDX As Int32 = 0
    Public Const ipNodeResFileDY As Int32 = 1
    Public Const ipNodeResFileDZ As Int32 = 2
    Public Const ipNodeResFileRX As Int32 = 3
    Public Const ipNodeResFileRY As Int32 = 4
    Public Const ipNodeResFileRZ As Int32 = 5

    Rem Custom Result Files - NODETEMP, NODEFLUX
    Public Const ipNodeResTemp As Int32 = 0

    Rem Custom Result Files - BEAMFORCE
    Public Const ipBeamResFileSF1 As Int32 = 0
    Public Const ipBeamResFileSF2 As Int32 = 1
    Public Const ipBeamResFileAxial As Int32 = 2
    Public Const ipBeamResFileBM1 As Int32 = 3
    Public Const ipBeamResFileBM2 As Int32 = 4
    Public Const ipBeamResFileTorque As Int32 = 5
    Public Const kBeamResFileForceSize As Int32 = 6

    Rem Custom Result Files - BEAMSTRAIN
    Public Const ipBeamResFileAxialStrain As Int32 = 2
    Public Const ipBeamResFileCurvature1 As Int32 = 3
    Public Const ipBeamResFileCurvature2 As Int32 = 4
    Public Const ipBeamResFileTwist As Int32 = 5
    Public Const kBeamResFileStrainSize As Int32 = 6

    Rem Custom Result Files - BEAMNODEREACT
    Public Const ipBeamResFileFX As Int32 = 0
    Public Const ipBeamResFileFY As Int32 = 1
    Public Const ipBeamResFileFZ As Int32 = 2
    Public Const ipBeamResFileMX As Int32 = 3
    Public Const ipBeamResFileMY As Int32 = 4
    Public Const ipBeamResFileMZ As Int32 = 5
    Public Const kBeamResFileReactSize As Int32 = 6

    Rem Custom Result Files - BEAMFLUX
    Public Const ipBeamResFileF As Int32 = 0
    Public Const ipBeamResFileG As Int32 = 1
    Public Const kBeamResFileFluxSize As Int32 = 2

    Rem Custom Result Files - PLATESTRESS for PlateShell - Local system
    Public Const ipPlateShellResFileNxx As Int32 = 0
    Public Const ipPlateShellResFileNyy As Int32 = 1
    Public Const ipPlateShellResFileNxy As Int32 = 2
    Public Const ipPlateShellResFileMxx As Int32 = 3
    Public Const ipPlateShellResFileMyy As Int32 = 4
    Public Const ipPlateShellResFileMxy As Int32 = 5
    Public Const ipPlateShellResFileQxz As Int32 = 6
    Public Const ipPlateShellResFileQyz As Int32 = 7
    Public Const ipPlateShellResFileZMinusSxx As Int32 = 8
    Public Const ipPlateShellResFileZMinusSyy As Int32 = 9
    Public Const ipPlateShellResFileZMinusSxy As Int32 = 10
    Public Const ipPlateShellResFileMidPlaneSxx As Int32 = 11
    Public Const ipPlateShellResFileMidPlaneSyy As Int32 = 12
    Public Const ipPlateShellResFileMidPlaneSxy As Int32 = 13
    Public Const ipPlateShellResFileZPlusSxx As Int32 = 14
    Public Const ipPlateShellResFileZPlusSyy As Int32 = 15
    Public Const ipPlateShellResFileZPlusSxy As Int32 = 16
    Public Const kPlateShellResFileStressSize As Int32 = 17

    Rem Custom Result Files - PLATESTRAIN for PlateShell - Local system
    Public Const ipPlateShellResFileExx As Int32 = 0
    Public Const ipPlateShellResFileEyy As Int32 = 1
    Public Const ipPlateShellResFileExy As Int32 = 2
    Public Const ipPlateShellResFileEzz As Int32 = 3
    Public Const ipPlateShellResFileKxx As Int32 = 4
    Public Const ipPlateShellResFileKyy As Int32 = 5
    Public Const ipPlateShellResFileKxy As Int32 = 6
    Public Const ipPlateShellResFileTxz As Int32 = 7
    Public Const ipPlateShellResFileTyz As Int32 = 8
    Public Const ipPlateShellResFileStoredE As Int32 = 9
    Public Const ipPlateShellResFileSpentE As Int32 = 10
    Public Const kPlateShellResFileStrainSize As Int32 = 11

    Rem Custom Result Files - PLATESTRESS for 2D Plates - Global system
    Public Const ipPlate2DResFileSXX As Int32 = 0
    Public Const ipPlate2DResFileSYY As Int32 = 1
    Public Const ipPlate2DResFileSXY As Int32 = 2
    Public Const ipPlate2DResFileSZZ As Int32 = 3
    Public Const kPlate2DResFileStressSize As Int32 = 4

    Rem Custom Result Files - PLATESTRAIN for 2D Plates - Global system
    Public Const ipPlate2DResFileEXX As Int32 = 0
    Public Const ipPlate2DResFileEYY As Int32 = 1
    Public Const ipPlate2DResFileEXY As Int32 = 2
    Public Const ipPlate2DResFileEZZ As Int32 = 3
    Public Const ipPlate2DResFileStoredE As Int32 = 4
    Public Const ipPlate2DResFileSpentE As Int32 = 5
    Public Const kPlate2DResFileStrainSize As Int32 = 6

    Rem Custom Result Files - PLATESTRESS for Axi Plates - Axisymmetric system
    Public Const ipPlateAxiResFileSRR As Int32 = 0
    Public Const ipPlateAxiResFileSZZ As Int32 = 1
    Public Const ipPlateAxiResFileSTT As Int32 = 2
    Public Const ipPlateAxiResFileSRT As Int32 = 3
    Public Const kPlateAxiResFileStressSize As Int32 = 4

    Rem Custom Result Files - PLATESTRAIN for Axi Plates - Axisymmetric system
    Public Const ipPlateAxiResFileERR As Int32 = 0
    Public Const ipPlateAxiResFileEZZ As Int32 = 1
    Public Const ipPlateAxiResFileETT As Int32 = 2
    Public Const ipPlateAxiResFileERT As Int32 = 3
    Public Const ipPlateAxiResFileStoredE As Int32 = 4
    Public Const ipPlateAxiResFileSpentE As Int32 = 5
    Public Const kPlateAxiResFileStrainSize As Int32 = 6

    Rem Custom Result Files - PLATENODEREACT
    Public Const ipPlateResFileFX As Int32 = 0
    Public Const ipPlateResFileFY As Int32 = 1
    Public Const ipPlateResFileFZ As Int32 = 2
    Public Const ipPlateResFileMX As Int32 = 3
    Public Const ipPlateResFileMY As Int32 = 4
    Public Const ipPlateResFileMZ As Int32 = 5
    Public Const kPlateResFileReactSize As Int32 = 6

    Rem Custom Result Files - PLATEFLUX
    Public Const ipPlateResFileFxx As Int32 = 0
    Public Const ipPlateResFileFyy As Int32 = 1
    Public Const ipPlateResFileGxx As Int32 = 2
    Public Const ipPlateResFileGyy As Int32 = 3
    Public Const kPlateResFileFluxSize As Int32 = 4

    Rem Custom Result Files - BRICKSTRESS
    Public Const ipBrickResFileSXX As Int32 = 0
    Public Const ipBrickResFileSYY As Int32 = 1
    Public Const ipBrickResFileSZZ As Int32 = 2
    Public Const ipBrickResFileSXY As Int32 = 3
    Public Const ipBrickResFileSYZ As Int32 = 4
    Public Const ipBrickResFileSZX As Int32 = 5
    Public Const kBrickResFileStressSize As Int32 = 6

    Rem Custom Result Files - BRICKSTRAIN
    Public Const ipBrickResFileExx As Int32 = 0
    Public Const ipBrickResFileEyy As Int32 = 1
    Public Const ipBrickResFileEzz As Int32 = 2
    Public Const ipBrickResFileExy As Int32 = 3
    Public Const ipBrickResFileEyz As Int32 = 4
    Public Const ipBrickResFileEzx As Int32 = 5
    Public Const ipBrickResFileStoredE As Int32 = 6
    Public Const ipBrickResFileSpentE As Int32 = 7
    Public Const kBrickResFileStrainSize As Int32 = 8

    Rem Custom Result Files - BRICKNODEREACT
    Public Const ipBrickResFileFX As Int32 = 0
    Public Const ipBrickResFileFY As Int32 = 1
    Public Const ipBrickResFileFZ As Int32 = 2
    Public Const kBrickResFileReactSize As Int32 = 3

    Rem Custom Result Files - BRICKFLUX
    Public Const ipBrickResFileFXX As Int32 = 0
    Public Const ipBrickResFileFYY As Int32 = 1
    Public Const ipBrickResFileFZZ As Int32 = 2
    Public Const ipBrickResFileGXX As Int32 = 3
    Public Const ipBrickResFileGYY As Int32 = 4
    Public Const ipBrickResFileGZZ As Int32 = 5
    Public Const kBrickResFileFluxSize As Int32 = 6

    Rem Edge Attachment Direction
    Public Const adPlanar As Int32 = 0
    Public Const adPlusZ As Int32 = 1
    Public Const adMinusZ As Int32 = 2

End Module
