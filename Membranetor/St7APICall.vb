Module St7APICall

    Declare Ansi Function St7Init Lib "St7API.DLL" () As Integer
    Declare Ansi Function St7Release Lib "St7API.DLL" () As Int32
    Declare Ansi Function St7APIVersion Lib "St7API.DLL" (ByRef Major As Int32, ByRef Minor As Int32, ByRef Point As Int32) As Int32
    Declare Ansi Function St7OpenFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal ScratchPath As String) As Int32
    Declare Ansi Function St7CloseFile Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7NewFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal ScratchPath As String) As Int32
    Declare Ansi Function St7SaveFile Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7SaveFileTo Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7OpenResultFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal SpectralName As String, ByVal Combinations As Byte, ByRef NumPrimary As Int32, ByRef NumSecondary As Int32) As Int32
    Declare Ansi Function St7GenerateLSACombinations Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumSecondary As Int32) As Int32
    Declare Ansi Function St7GenerateEnvelopes Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumLimitEnvelopes As Int32, ByRef NumCombinationEnvelopes As Int32, ByRef NumFactorsEnvelopes As Int32) As Int32
    Declare Ansi Function St7CloseResultFile Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7GetDisplayOptionsPath Lib "St7API.DLL" (ByVal ConfigPath As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetDisplayOptionsPath Lib "St7API.DLL" (ByVal ConfigPath As String) As Int32
    Declare Ansi Function St7GetLibraryPath Lib "St7API.DLL" (ByVal LibraryPath As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLibraryPath Lib "St7API.DLL" (ByVal LibraryPath As String) As Int32
    Declare Ansi Function St7GetPath Lib "St7API.DLL" (ByVal St7Path As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetLastError Lib "St7API.DLL" () As Int32
    Declare Ansi Function St7GetAPIErrorString Lib "St7API.DLL" (ByVal iErr As Int32, ByVal ErrorString As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetSolverErrorString Lib "St7API.DLL" (ByVal iErr As Int32, ByVal ErrorString As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7TransformToUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7TransformToXYZ Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7VectorTransformToUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByRef Position As Double, ByRef VXYZ As Double) As Int32
    Declare Ansi Function St7VectorTransformToXYZ Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByRef Position As Double, ByRef VXYZ As Double) As Int32
    Declare Ansi Function St7GetCleanMeshData Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCleanMeshData Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7CleanMesh Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DeleteUnusedNodes Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumDeleted As Int32) As Int32
    Declare Ansi Function St7InvalidateElement Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32) As Int32
    Declare Ansi Function St7DeleteInvalidElements Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByRef NumDeleted As Int32) As Int32
    Declare Ansi Function St7GetPlateUV Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef XYZ As Double, ByRef UV As Double) As Int32
    Declare Ansi Function St7GetBrickUVW Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByRef XYZ As Double, ByRef UVW As Double) As Int32
    Declare Ansi Function St7GetNumElementResultGaussPoints Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal NumNodes As Int32, ByRef NumGauss As Int32) As Int32
    Declare Ansi Function St7ConvertElementResultNodeToGaussPoint Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal NumNodes As Int32, ByVal NumColumns As Int32, ByRef NodeDoubles As Double, ByRef NumGauss As Int32, ByRef GaussDoubles As Double) As Int32
    Declare Ansi Function St7SetResultOptions Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetResultOptions Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetToolOptions Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetToolOptions Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7EnableModelStrainUnit Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DisableModelStrainUnit Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7EnableModelRotationUnit Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DisableModelRotationUnit Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7EnableModelRCUnit Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DisableModelRCUnit Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7SetEntitySelectState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EntityNum As Int32, ByVal EndEdgeFace As Int32, ByVal Selected As Byte) As Int32
    Declare Ansi Function St7GetEntitySelectState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EntityNum As Int32, ByVal EndEdgeFace As Int32, ByRef Selected As Byte) As Int32
    Declare Ansi Function St7CreateModelWindow Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DestroyModelWindow Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7GetModelWindowState Lib "St7API.DLL" (ByVal uID As Int32, ByRef State As Int32) As Int32
    Declare Ansi Function St7GetModelWindowHandle Lib "St7API.DLL" (ByVal uID As Int32, ByRef Handle As Int32) As Int32
    Declare Ansi Function St7SetModelWindowParent Lib "St7API.DLL" (ByVal uID As Int32, ByVal Handle As Int32) As Int32
    Declare Ansi Function St7ShowModelWindow Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7HideModelWindow Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7RedrawModel Lib "St7API.DLL" (ByVal uID As Int32, ByVal Rescale As Byte) As Int32
    Declare Ansi Function St7ClearModelWindow Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7ShowWindowPopUp Lib "St7API.DLL" (ByVal uID As Int32, ByVal MenuGroup As Int32) As Int32
    Declare Ansi Function St7HideWindowPopUp Lib "St7API.DLL" (ByVal uID As Int32, ByVal MenuGroup As Int32) As Int32
    Declare Ansi Function St7ShowWindowTopPanel Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7HideWindowTopPanel Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7ShowWindowToolbar Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7HideWindowToolbar Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7ShowWindowStatusBar Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7HideWindowStatusBar Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7ShowSelectionToolBar Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7HideSelectionToolBar Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7SetSelectionToolBarPosition Lib "St7API.DLL" (ByVal uID As Int32, ByVal Left As Int32, ByVal Top As Int32) As Int32
    Declare Ansi Function St7GetSelectionToolBarPosition Lib "St7API.DLL" (ByVal uID As Int32, ByRef Left As Int32, ByRef Top As Int32) As Int32
    Declare Ansi Function St7RotateModel Lib "St7API.DLL" (ByVal uID As Int32, ByVal RX As Double, ByVal RY As Double, ByVal RZ As Double) As Int32
    Declare Ansi Function St7ShowEntity Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32) As Int32
    Declare Ansi Function St7HideEntity Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32) As Int32
    Declare Ansi Function St7SetEntityDisplay Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetEntityDisplay Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7ShowPointAttributes Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7HidePointAttributes Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7ShowEntityAttributes Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7HideEntityAttributes Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7PositionModelWindow Lib "St7API.DLL" (ByVal uID As Int32, ByVal Left As Int32, ByVal Top As Int32, ByVal Width As Int32, ByVal Height As Int32) As Int32
    Declare Ansi Function St7GetModelWindowPosition Lib "St7API.DLL" (ByVal uID As Int32, ByRef Left As Int32, ByRef Top As Int32, ByRef Width As Int32, ByRef Height As Int32) As Int32
    Declare Ansi Function St7GetDrawAreaSize Lib "St7API.DLL" (ByVal uID As Int32, ByRef Width As Int32, ByRef Height As Int32) As Int32
    Declare Ansi Function St7ShowProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7HideProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7ShowGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7HideGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7SetBeamResultDisplay Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetPlateResultDisplay Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetBrickResultDisplay Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetWindowResultCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7SetWindowLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7SetWindowFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7SetWindowUCSCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7SetEntityContourFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal FileType As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GetEntityContourFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByRef FileType As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetDisplacementScale Lib "St7API.DLL" (ByVal uID As Int32, ByVal DispScale As Double, ByVal ScaleType As Int32) As Int32
    Declare Ansi Function St7GetDisplacementScale Lib "St7API.DLL" (ByVal uID As Int32, ByRef DispScale As Double, ByRef ScaleType As Int32) As Int32
    Declare Ansi Function St7ImportST7File Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportIGESFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByRef Doubles As Double, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportACISFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByRef Doubles As Double, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportSTEPFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByRef Doubles As Double, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportST6BinaryFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportST6TextFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportDXFFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportSTLFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportNASTRANFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportANSYSFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal LoadCaseFilePath As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportSTAADFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ImportSAP2000File Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ExportImageFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal ImageType As Int32, ByVal Width As Int32, ByVal Height As Int32) As Int32
    Declare Ansi Function St7ExportST7File Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal Mode As Int32, ByVal ExportFormat As Int32) As Int32
    Declare Ansi Function St7ExportIGESFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ExportSTEPFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ExportDXFFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ExportNASTRANFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByRef Doubles As Double, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7ExportANSYSFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7PlayAnimationFile Lib "St7API.DLL" (ByVal pHandle As Int32, ByVal FileName As String, ByRef aHandle As Int32) As Int32
    Declare Ansi Function St7CreateAnimation Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef aHandle As Int32) As Int32
    Declare Ansi Function St7CreateAnimationFile Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7CloseAnimation Lib "St7API.DLL" (ByVal aHandle As Int32) As Int32
    Declare Ansi Function St7SetAnimationCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Activate As Byte) As Int32
    Declare Ansi Function St7GetAnimationCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Active As Byte) As Int32
    Declare Ansi Function St7GetTotal Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByRef Total As Int32) As Int32
    Declare Ansi Function St7GetTitle Lib "St7API.DLL" (ByVal uID As Int32, ByVal TitleType As Int32, ByVal TitleString As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetTitle Lib "St7API.DLL" (ByVal uID As Int32, ByVal TitleType As Int32, ByVal TitleString As String) As Int32
    Declare Ansi Function St7AddComment Lib "St7API.DLL" (ByVal uID As Int32, ByVal CommentString As String) As Int32
    Declare Ansi Function St7GetNumComments Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumComments As Int32) As Int32
    Declare Ansi Function St7GetComment Lib "St7API.DLL" (ByVal uID As Int32, ByVal Comment As Int32, ByVal CommentString As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetComment Lib "St7API.DLL" (ByVal uID As Int32, ByVal Comment As Int32, ByVal CommentString As String) As Int32
    Declare Ansi Function St7DeleteComment Lib "St7API.DLL" (ByVal uID As Int32, ByVal Comment As Int32) As Int32
    Declare Ansi Function St7GetBeamAxisSystem Lib "St7API.DLL" (ByVal uID As Int32, ByVal EltNum As Int32, ByVal Initial As Byte, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateAxisSystem Lib "St7API.DLL" (ByVal uID As Int32, ByVal EltNum As Int32, ByVal Initial As Byte, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickFaceAxisSystem Lib "St7API.DLL" (ByVal uID As Int32, ByVal EltNum As Int32, ByVal FaceNum As Int32, ByVal Initial As Byte, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateNumPlies Lib "St7API.DLL" (ByVal uID As Int32, ByVal EltNum As Int32, ByRef NumPlies As Int32) As Int32
    Declare Ansi Function St7GetNumBXSLoopsAndPlates Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef NumLoops As Int32, ByRef NumPlates As Int32) As Int32
    Declare Ansi Function St7GetNumBXSLoopPoints Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal LoopNum As Int32, ByRef NumPoints As Int32) As Int32
    Declare Ansi Function St7GetBXSLoop Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal LoopNum As Int32, ByVal MaxPoints As Int32, ByRef NumPoints As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GenerateBXS Lib "St7API.DLL" (ByVal uID As Int32, ByVal BXSName As String, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7NewLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7NewSeismicCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7NewFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7GetNumLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumCases As Int32) As Int32
    Declare Ansi Function St7GetNumSeismicCase Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumCases As Int32) As Int32
    Declare Ansi Function St7GetNumFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumCases As Int32) As Int32
    Declare Ansi Function St7SetLoadCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7GetLoadCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetSeismicCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7GetSeismicCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetFreedomCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7GetFreedomCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLoadCaseDefaults Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Defaults As Double) As Int32
    Declare Ansi Function St7GetLoadCaseDefaults Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Defaults As Double) As Int32
    Declare Ansi Function St7SetSeismicCaseDefaults Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Defaults As Double) As Int32
    Declare Ansi Function St7GetSeismicCaseDefaults Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Defaults As Double) As Int32
    Declare Ansi Function St7SetFreedomCaseDefaults Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Defaults As Int32) As Int32
    Declare Ansi Function St7GetFreedomCaseDefaults Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Defaults As Int32) As Int32
    Declare Ansi Function St7SetLoadCaseType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseType As Int32) As Int32
    Declare Ansi Function St7GetLoadCaseType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef CaseType As Int32) As Int32
    Declare Ansi Function St7SetLoadCaseGravityDir Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal GravDir As Int32) As Int32
    Declare Ansi Function St7GetLoadCaseGravityDir Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef GravDir As Int32) As Int32
    Declare Ansi Function St7SetFreedomCaseType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseType As Int32) As Int32
    Declare Ansi Function St7GetFreedomCaseType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef CaseType As Int32) As Int32
    Declare Ansi Function St7SetLoadCaseMassOption Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal SMass As Byte, ByVal NSMass As Byte) As Int32
    Declare Ansi Function St7GetLoadCaseMassOption Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef SMass As Byte, ByRef NSMass As Byte) As Int32
    Declare Ansi Function St7EnableSeismicNSMassCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal SeismicCaseNum As Int32, ByVal LoadCaseNum As Int32) As Int32
    Declare Ansi Function St7DisableSeismicNSMassCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal SeismicCaseNum As Int32, ByVal LoadCaseNum As Int32) As Int32
    Declare Ansi Function St7GetSeismicNSMassCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal SeismicCaseNum As Int32, ByVal LoadCaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7DeleteLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DeleteSeismicCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DeleteFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7SetUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByVal UCSType As Int32, ByRef UCSDoubles As Double) As Int32
    Declare Ansi Function St7GetUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByRef UCSType As Int32, ByRef UCSDoubles As Double) As Int32
    Declare Ansi Function St7SetUCSName Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByVal UCSName As String) As Int32
    Declare Ansi Function St7GetUCSName Lib "St7API.DLL" (ByVal uID As Int32, ByVal UCSId As Int32, ByVal UCSName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetUCSID Lib "St7API.DLL" (ByVal uID As Int32, ByVal Index As Int32, ByRef UCSId As Int32) As Int32
    Declare Ansi Function St7GetNumUCS Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumUCS As Int32) As Int32
    Declare Ansi Function St7GetGroupIDName Lib "St7API.DLL" (ByVal uID As Int32, ByVal ID As Int32, ByVal GName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetNumGroups Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumGroups As Int32) As Int32
    Declare Ansi Function St7GetGroupByIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal Index As Int32, ByVal GName As String, ByVal MaxStringLen As Int32, ByRef GroupID As Int32) As Int32
    Declare Ansi Function St7NewChildGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal ParentID As Int32, ByVal GName As String, ByRef ChildID As Int32) As Int32
    Declare Ansi Function St7GetGroupParent Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32, ByRef ParentID As Int32) As Int32
    Declare Ansi Function St7GetGroupChild Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32, ByRef ChildID As Int32) As Int32
    Declare Ansi Function St7GetGroupSibling Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32, ByRef SiblingID As Int32) As Int32
    Declare Ansi Function St7DeleteGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7SetGroupColour Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32, ByVal GroupCol As Int32) As Int32
    Declare Ansi Function St7GetGroupColour Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32, ByRef GroupCol As Int32) As Int32
    Declare Ansi Function St7AddStage Lib "St7API.DLL" (ByVal uID As Int32, ByVal StageName As String, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7InsertStage Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal StageName As String, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7DeleteStage Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32) As Int32
    Declare Ansi Function St7GetNumStages Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumStages As Int32) As Int32
    Declare Ansi Function St7GetStageName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal StageName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetStageName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal StageName As String) As Int32
    Declare Ansi Function St7GetStageData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetStageData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7EnableStageGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7DisableStageGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7GetStageGroupState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal GroupID As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetUnits Lib "St7API.DLL" (ByVal uID As Int32, ByRef Units As Int32) As Int32
    Declare Ansi Function St7SetUnits Lib "St7API.DLL" (ByVal uID As Int32, ByRef Units As Int32) As Int32
    Declare Ansi Function St7GetRCUnits Lib "St7API.DLL" (ByVal uID As Int32, ByRef AreaUnit As Int32, ByRef LengthUnit As Int32) As Int32
    Declare Ansi Function St7SetRCUnits Lib "St7API.DLL" (ByVal uID As Int32, ByVal AreaUnit As Int32, ByVal LengthUnit As Int32) As Int32
    Declare Ansi Function St7ConvertUnits Lib "St7API.DLL" (ByVal uID As Int32, ByRef Units As Int32) As Int32
    Declare Ansi Function St7SetNodeXYZ Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7GetNodeXYZ Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7GetNodeUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal UCSId As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7SetNodeUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal UCSId As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7SetElementConnection Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal PropNum As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7GetElementConnection Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7GetElementData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByRef EltData As Double) As Int32
    Declare Ansi Function St7GetElementCentroid Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal FaceEdgeNum As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7SetMasterSlaveLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByVal UCSId As Int32, ByRef Connection As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetMasterSlaveLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef UCSId As Int32, ByRef Connection As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetSectorSymmetryLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByVal Axis As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7GetSectorSymmetryLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Axis As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7SetCouplingLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByVal Couple As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7GetCouplingLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Couple As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7SetPinnedLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7GetPinnedLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7SetRigidLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByVal UCSId As Int32, ByVal Plane As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7GetRigidLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef UCSId As Int32, ByRef Plane As Int32, ByRef Connection As Int32) As Int32
    Declare Ansi Function St7SetShrinkLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetShrinkLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetTwoPointLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetTwoPointLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetAttachmentLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetAttachmentLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef Connection As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetMultiPointLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByVal NumNodes As Int32, ByVal FactorsType As Int32, ByVal Couple As Int32, ByRef Connection As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNumMultiPointLinkNodes Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef NumNodes As Int32) As Int32
    Declare Ansi Function St7GetMultiPointLink Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef FactorsType As Int32, ByRef Couple As Int32, ByRef Connection As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetLinkType Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef LinkType As Int32) As Int32
    Declare Ansi Function St7GetVertexXYZ Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef XYZ As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceOuterLoops Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef OuterLoops As Int32) As Int32
    Declare Ansi Function St7GetNumGeometryFaceCavityLoops Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef NumCavityLoops As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceCavityLoops Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal MaxCavityLoops As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetNumGeometryFaceEdges Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef NumEdges As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceEdges Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal MaxEdges As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetGeometryEdgeLength Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByRef EdgeLength As Double) As Int32
    Declare Ansi Function St7GetNumGeometryFaceVertices Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef NumVertices As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceVertices Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal MaxVertices As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetGeometryEdgeVertices Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByRef EdgeVertices As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceSurface Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef SurfaceNum As Int32) As Int32
    Declare Ansi Function St7GetGeometrySurfaceType Lib "St7API.DLL" (ByVal uID As Int32, ByVal SurfaceNum As Int32, ByRef SurfaceType As Int32) As Int32
    Declare Ansi Function St7InvalidateGeometryFace Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32) As Int32
    Declare Ansi Function St7InvalidateGeometryFaceCavityLoopID Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal LoopNum As Int32) As Int32
    Declare Ansi Function St7InvalidateGeometryFaceCavityLoopIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal LoopIndex As Int32) As Int32
    Declare Ansi Function St7DeleteInvalidGeometryFaces Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumFacesDeleted As Int32, ByRef NumCavityLoopsDeleted As Int32) As Int32
    Declare Ansi Function St7GetCleanGeometryData Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCleanGeometryData Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7CleanGeometry Lib "St7API.DLL" (ByVal uID As Int32, ByRef ChangesMade As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7GetGeometrySize Lib "St7API.DLL" (ByVal uID As Int32, ByRef Size As Double) As Int32
    Declare Ansi Function St7SurfaceMesh Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7SolidTetMesh Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7MeshFromLoops Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double, ByRef Loops As Int32, ByRef Points As Double, ByVal Mode As Int32) As Int32
    Declare Ansi Function St7SetLoadPath Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetLoadPath Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7DeleteLoadPath Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathID As Int32) As Int32
    Declare Ansi Function St7SetNodeID Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal NodeID As Int32) As Int32
    Declare Ansi Function St7SetNodeRestraint6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeForce3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeMoment3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeTemperature1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeTemperatureType1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByVal tType As Int32) As Int32
    Declare Ansi Function St7SetNodeTemperatureTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7SetNodeKTranslation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeKRotation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeTMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeRMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeKDamping3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetNodeInitialVelocity3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeAcceleration3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByVal ResponseType As Int32, ByVal UCSId As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7GetNodeID Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByRef NodeID As Int32) As Int32
    Declare Ansi Function St7GetNodeRestraint6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeForce3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeMoment3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeTemperature1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeTemperatureType1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef tType As Int32) As Int32
    Declare Ansi Function St7GetNodeTemperatureTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7GetNodeTMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeRMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeKTranslation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeKRotation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeKDamping3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetNodeInitialVelocity3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeAcceleration3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNodeResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef ResponseType As Int32, ByRef UCSId As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7SetBeamID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamID As Int32) As Int32
    Declare Ansi Function St7SetBeamReferenceAngle1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamConnectionUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal UCSId As Int32) As Int32
    Declare Ansi Function St7SetBeamTaper2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal TaperAxis As Int32, ByVal TaperType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamOffset2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamSupport2F Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamSectionFactor7 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamTRelease3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamRRelease3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCableFreeLength1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamRadius1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPipePressure2AF Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPipeTemperature2OT Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamStringGroup1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal StringID As Int32) As Int32
    Declare Ansi Function St7SetBeamPreLoad1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal LoadType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamTempGradient2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCFL4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCFG4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCML4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCMG4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamDLL6ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal CaseNum As Int32, ByVal DLType As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamDML6ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal CaseNum As Int32, ByVal DLType As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamDLG6ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal ProjectFlag As Int32, ByVal CaseNum As Int32, ByVal DLType As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamNSMass10ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal DLType As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBeamRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBeamFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBeamHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBeamResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7SetBeamCreepLoadingAge1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamEndAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal AttachType As Int32, ByVal ConnectType As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef BeamID As Int32) As Int32
    Declare Ansi Function St7GetBeamReferenceAngle1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamConnectionUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByRef UCSId As Int32) As Int32
    Declare Ansi Function St7GetBeamTaper2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal TaperAxis As Int32, ByRef TaperType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamOffset2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamSupport2F Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamSectionFactor7 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamTRelease3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamRRelease3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamCableFreeLength1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamRadius1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef BeamDir As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPipePressure2AF Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPipeTemperature2OT Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamStringGroup1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef StringID As Int32) As Int32
    Declare Ansi Function St7GetBeamPreLoad1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef LoadType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamTempGradient2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamCFL4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamCFG4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamCML4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamCMG4ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamDLL6ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef DLType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamDML6ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef DLType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamDLG6ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef ProjectFlag As Int32, ByRef DLType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamNSMass10ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef DLType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBeamRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBeamFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBeamHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBeamResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByVal CaseNum As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7GetBeamCreepLoadingAge1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamEndAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamEnd As Int32, ByRef AttachType As Int32, ByRef ConnectType As Int32, ByRef PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateID Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal PlateID As Int32) As Int32
    Declare Ansi Function St7SetPlateXAngle1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateThickness2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateOffset1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateFaceSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeRelease1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal EdgeNum As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7SetPlatePreLoad3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal LoadType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateTempGradient1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlatePointForce6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Position As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlatePointMoment6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Position As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgePressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeNormalShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateNormalPressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateGlobalPressure3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal ProjectFlag As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateShear2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetPlateEdgeRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetPlateFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetPlateFaceConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateFaceConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetPlateFaceRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateFaceRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetPlateHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetPlateSoilStress2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateSoilRatio2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal ResponseType As Int32, ByVal UCSId As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7SetPlateLoadPatch4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal PatchType As Int32, ByVal EdgeBits As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateReinforcement2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal LayoutID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateCreepLoadingAge1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal EdgeNum As Int32, ByVal Direction As Int32, ByVal AttachType As Int32, ByVal ConnectType As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateFaceAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal Surface As Int32, ByVal AttachType As Int32, ByVal ConnectType As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateID Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef PlateID As Int32) As Int32
    Declare Ansi Function St7GetPlateXAngle1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateThickness2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateOffset1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateFaceSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeRelease1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal EdgeNum As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7GetPlatePreLoad3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef LoadType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateTempGradient1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlatePointForce6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Position As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlatePointMoment6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Position As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgePressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeNormalShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateNormalPressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateGlobalPressure3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef ProjectFlag As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateShear2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetPlateEdgeRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetPlateFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetPlateFaceConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateFaceConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetPlateFaceRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateFaceRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetPlateHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetPlateSoilStress2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateSoilRatio2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef ResponseType As Int32, ByRef UCSId As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7GetPlateLoadPatch4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef PatchType As Int32, ByRef EdgeBits As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateReinforcement2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef LayoutID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateCreepLoadingAge1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateEdgeAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal EdgeNum As Int32, ByRef Direction As Int32, ByRef AttachType As Int32, ByRef ConnectType As Int32, ByRef PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateFaceAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal Surface As Int32, ByRef AttachType As Int32, ByRef ConnectType As Int32, ByRef PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal BrickID As Int32) As Int32
    Declare Ansi Function St7SetBrickLocalAxes1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal UCSId As Int32) As Int32
    Declare Ansi Function St7SetBrickSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickPreLoad3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByVal LoadType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickPointForce6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Position As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickNormalPressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickGlobalPressure3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal ProjectFlag As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickShear2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBrickRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBrickFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBrickHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetBrickSoilStress2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickSoilRatio2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7SetBrickCreepLoadingAge1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickFaceAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal AttachType As Int32, ByVal ConnectType As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByRef BrickID As Int32) As Int32
    Declare Ansi Function St7GetBrickLocalAxes1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByRef UCSId As Int32) As Int32
    Declare Ansi Function St7GetBrickSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickPreLoad3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef LoadType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickPointForce6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Position As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickNormalPressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickGlobalPressure3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef ProjectFlag As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickShear2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBrickRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBrickFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBrickHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetBrickSoilStress2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickSoilRatio2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickResponse Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7GetBrickCreepLoadingAge1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickFaceAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByRef AttachType As Int32, ByRef ConnectType As Int32, ByRef PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexType Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal VertexType As Int32) As Int32
    Declare Ansi Function St7SetVertexID Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal VertexID As Int32) As Int32
    Declare Ansi Function St7SetVertexMeshSize1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexRestraint6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexForce3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexMoment3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexTemperature1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexTemperatureType1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByVal tType As Int32) As Int32
    Declare Ansi Function St7SetVertexTemperatureTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7SetVertexKTranslation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexKRotation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexTMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexRMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexKDamping3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetVertexHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetVertexType Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef VertexType As Int32) As Int32
    Declare Ansi Function St7GetVertexID Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef VertexID As Int32) As Int32
    Declare Ansi Function St7GetVertexMeshSize1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexRestraint6 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexForce3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexMoment3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexTemperature1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexTemperatureType1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef tType As Int32) As Int32
    Declare Ansi Function St7GetVertexTemperatureTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7GetVertexKTranslation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexKRotation3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexTMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexRMass3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexKDamping3F Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetVertexHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal VertexNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetGeometryEdgeType Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal EdgeType As Int32) As Int32
    Declare Ansi Function St7SetGeometryEdgeRelease1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7SetGeometryEdgeSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryEdgePressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryEdgeShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryEdgeNormalShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryEdgeConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryEdgeConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetGeometryEdgeRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryEdgeRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetGeometryEdgeFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryEdgeFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetGeometryEdgeAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal Direction As Int32, ByVal AttachType As Int32, ByVal ConnectType As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgeType Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByRef EdgeType As Int32) As Int32
    Declare Ansi Function St7GetGeometryEdgeRelease1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByRef Status As Int32) As Int32
    Declare Ansi Function St7GetGeometryEdgeSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgePressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgeShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgeNormalShear1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgeConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgeConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetGeometryEdgeRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgeRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetGeometryEdgeFlux1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryEdgeFluxTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetGeometryEdgeAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal EdgeNum As Int32, ByRef Direction As Int32, ByRef AttachType As Int32, ByRef ConnectType As Int32, ByRef PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7SetGeometryFaceID Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal FaceID As Int32) As Int32
    Declare Ansi Function St7SetGeometryFaceOffset1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceTempGradient1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceNormalPressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceGlobalPressure3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal ProjectFlag As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetGeometryFaceRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetGeometryFaceHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetGeometryFaceHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7SetGeometryFaceAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal Surface As Int32, ByVal AttachType As Int32, ByVal ConnectType As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef PropNum As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceID Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef FaceID As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceOffset1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceSupport1F Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceTempGradient1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceNormalPressure1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceGlobalPressure3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef ProjectFlag As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceNSMass5 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceConvectionTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceRadiationTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByVal Surface As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceHeatSource1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetGeometryFaceHeatSourceTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Tables As Int32) As Int32
    Declare Ansi Function St7GetGeometryFaceAttachment1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal FaceNum As Int32, ByVal Surface As Int32, ByRef AttachType As Int32, ByRef ConnectType As Int32, ByRef PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetElementProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByRef PropNum As Int32) As Int32
    Declare Ansi Function St7GetElementPropertySequence Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal MaxPoints As Int32, ByRef Props As Int32, ByRef Stages As Int32) As Int32
    Declare Ansi Function St7SetElementProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7SetElementPropertySwitch Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal PropID As Int32, ByVal StageID As Int32) As Int32
    Declare Ansi Function St7DeleteAttribute Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EntityNum As Int32, ByVal AttributeOrd As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetEntityGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EntityNum As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7GetEntityGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EntityNum As Int32, ByRef GroupID As Int32) As Int32
    Declare Ansi Function St7GetTotalProperties Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumProperties As Int32, ByRef LastProperty As Int32) As Int32
    Declare Ansi Function St7GetTotalCreepDefinitions Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumSets As Int32, ByRef LastSet As Int32) As Int32
    Declare Ansi Function St7GetTotalLaminateStacks Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumStacks As Int32, ByRef LastStack As Int32) As Int32
    Declare Ansi Function St7GetTotalLoadPathTemplates Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumTemplates As Int32, ByRef LastTemplate As Int32) As Int32
    Declare Ansi Function St7GetTotalReinforcementLayouts Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumLayouts As Int32, ByRef LastLayout As Int32) As Int32
    Declare Ansi Function St7GetPropertyNumByIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropIndex As Int32, ByRef PropNum As Int32) As Int32
    Declare Ansi Function St7GetCreepDefinitionNumByIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal Index As Int32, ByRef CreepNum As Int32) As Int32
    Declare Ansi Function St7GetLaminateStackNumByIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal Index As Int32, ByRef LaminateNum As Int32) As Int32
    Declare Ansi Function St7GetLoadPathTemplateNumByIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal Index As Int32, ByRef PathNum As Int32) As Int32
    Declare Ansi Function St7GetReinforcementLayoutNumByIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal Index As Int32, ByRef LayoutNum As Int32) As Int32
    Declare Ansi Function St7SetPropertyName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal PropName As String) As Int32
    Declare Ansi Function St7GetPropertyName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal PropName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetPropertyColour Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal PropCol As Int32) As Int32
    Declare Ansi Function St7GetPropertyColour Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByRef PropCol As Int32) As Int32
    Declare Ansi Function St7SetPropertyTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal ptType As Int32, ByVal PropNum As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetPropertyTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal ptType As Int32, ByVal PropNum As Int32, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7SetPropertyCreepID Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal CreepID As Int32) As Int32
    Declare Ansi Function St7GetPropertyCreepID Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByRef CreepID As Int32) As Int32
    Declare Ansi Function St7SetMaterialName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal MaterialName As String) As Int32
    Declare Ansi Function St7GetMaterialName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal MaterialName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetTimeDependentModType Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal ModType As Int32) As Int32
    Declare Ansi Function St7GetTimeDependentModType Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByRef ModType As Int32) As Int32
    Declare Ansi Function St7SetHardeningType Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal HardType As Int32) As Int32
    Declare Ansi Function St7GetHardeningType Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByRef HardType As Int32) As Int32
    Declare Ansi Function St7GetAlphaTempType Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByRef AlphaTempType As Int32) As Int32
    Declare Ansi Function St7SetAlphaTempType Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal AlphaTempType As Int32) As Int32
    Declare Ansi Function St7NewBeamProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal BeamType As Int32, ByVal PropName As String) As Int32
    Declare Ansi Function St7GetBeamPropertyData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef SectionData As Double, ByRef BeamMaterial As Double) As Int32
    Declare Ansi Function St7GetBeamSectionName Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal SectionName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetBeamSectionName Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal SectionName As String) As Int32
    Declare Ansi Function St7SetBeamPropertyType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal BeamType As Int32) As Int32
    Declare Ansi Function St7SetBeamMirrorOption Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal MirrorType As Int32, ByVal CompatibleTwist As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamNonlinearType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal NonlinType As Int32) As Int32
    Declare Ansi Function St7GetBeamNonlinearType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef NonlinType As Int32) As Int32
    Declare Ansi Function St7SetBeamSectionPropertyData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamSectionPropertyData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamSectionGeometry Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal SectionType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamSectionGeometry Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef SectionType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamSectionNominalDiscretisation Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetBeamSectionNominalDiscretisation Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetBeamSectionCircularDiscretisation Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetBeamSectionCircularDiscretisation Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7CalculateBeamSectionProperties Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal DoShear As Byte, ByVal ExactJ As Byte) As Int32
    Declare Ansi Function St7AssignBXS Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal BXSName As String) As Int32
    Declare Ansi Function St7SetSpringDamperData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetSpringDamperData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetTrussData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetTrussData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetCableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetCableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetCutoffBarData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetCutoffBarData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPointContactData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPointContactData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPipeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPipeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetConnectionData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetConnectionData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetUserBeamData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetUserBeamData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamMaterialData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamMaterialData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamUsePoisson Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7SetBeamUseShearMod Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7GetBeamUseMomCurv Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef UseMomCurv As Byte) As Int32
    Declare Ansi Function St7SetBeamUseMomCurv Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal UseMomCurv As Byte) As Int32
    Declare Ansi Function St7NewPlateProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal PlateType As Int32, ByVal MaterialType As Int32, ByVal PropName As String) As Int32
    Declare Ansi Function St7GetPlatePropertyData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef SectionData As Double, ByRef PlateMaterial As Double) As Int32
    Declare Ansi Function St7SetPlatePropertyType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal PlateType As Int32, ByVal MaterialType As Int32) As Int32
    Declare Ansi Function St7GetPlatePropertyType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef PlateType As Int32, ByRef MaterialType As Int32) As Int32
    Declare Ansi Function St7SetPlateNonlinearType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal NonlinType As Int32, ByVal YieldType As Int32) As Int32
    Declare Ansi Function St7GetPlateNonlinearType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef NonlinType As Int32, ByRef YieldType As Int32) As Int32
    Declare Ansi Function St7SetPlateThickness Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateThickness Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateLayers Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal NumLayers As Int32) As Int32
    Declare Ansi Function St7GetPlateLayers Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef NumLayers As Int32) As Int32
    Declare Ansi Function St7SetPlateIsotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateIsotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateOrthotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateOrthotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateRubberMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal RubberType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateRubberMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef RubberType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateAnisotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal MatType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateAnisotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef MatType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateUserDefinedMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal MatType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateUserDefinedMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef MatType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateMCDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateMCDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateSoilDCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateSoilDCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateSoilCCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateSoilCCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateSoilMCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateSoilMCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateSoilDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateSoilDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateSoilLSMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateSoilLSMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateFluidMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateFluidMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateUseReducedInt Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef UseReducedInt As Byte) As Int32
    Declare Ansi Function St7SetPlateUseReducedInt Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal UseReducedInt As Byte) As Int32
    Declare Ansi Function St7NewBrickProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal MaterialType As Int32, ByVal PropName As String) As Int32
    Declare Ansi Function St7GetBrickPropertyData Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef BrickMaterial As Double) As Int32
    Declare Ansi Function St7SetBrickPropertyType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal MaterialType As Int32) As Int32
    Declare Ansi Function St7GetBrickPropertyType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef MaterialType As Int32) As Int32
    Declare Ansi Function St7SetBrickNonlinearType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal NonlinType As Int32, ByVal YieldType As Int32) As Int32
    Declare Ansi Function St7GetBrickNonlinearType Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef NonlinType As Int32, ByRef YieldType As Int32) As Int32
    Declare Ansi Function St7SetBrickIsotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickIsotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickOrthotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickOrthotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickAnisotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal MatType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickAnisotropicMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef MatType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickRubberMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal RubberType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickRubberMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef RubberType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickMCDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickMCDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickSoilDCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickSoilDCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickSoilCCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickSoilCCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickSoilMCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickSoilMCMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickSoilDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickSoilDPMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickSoilLSMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickSoilLSMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickFluidMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickFluidMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickAddBubbleFunction Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef AddBubbleFunction As Byte) As Int32
    Declare Ansi Function St7SetBrickAddBubbleFunction Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal AddBubbleFunction As Byte) As Int32
    Declare Ansi Function St7DeleteProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7DeleteUnusedProperties Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByRef NumDeleted As Int32) As Int32
    Declare Ansi Function St7UpdateElementPropertyData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7NewPlyProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal PropName As String) As Int32
    Declare Ansi Function St7GetPlyMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlyMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetPlateLaminateMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef LamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateLaminateMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal LamNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7NewLaminate Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal LamName As String) As Int32
    Declare Ansi Function St7GetLaminateName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal LamName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLaminateName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal LamName As String) As Int32
    Declare Ansi Function St7GetLaminateNumPlies Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByRef NumPlies As Int32) As Int32
    Declare Ansi Function St7GetLaminatePly Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal Pos As Int32, ByRef PlyPropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLaminatePly Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal Pos As Int32, ByVal PlyPropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7AddLaminatePly Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal PlyPropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7DeleteLaminatePly Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7InsertLaminatePly Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByVal Pos As Int32, ByVal PlyPropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetLaminateMatrices Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLaminateMatrices Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7DeleteLaminate Lib "St7API.DLL" (ByVal uID As Int32, ByVal LamNum As Int32) As Int32
    Declare Ansi Function St7DeleteUnusedLaminates Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumDeleted As Int32) As Int32
    Declare Ansi Function St7NewReinforcementLayout Lib "St7API.DLL" (ByVal uID As Int32, ByVal LayoutID As Int32, ByVal LayoutName As String) As Int32
    Declare Ansi Function St7GetReinforcementName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LayoutID As Int32, ByVal LayoutName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetReinforcementName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LayoutID As Int32, ByVal LayoutName As String) As Int32
    Declare Ansi Function St7GetReinforcementData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LayoutID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetReinforcementData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LayoutID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7DeleteReinforcementLayout Lib "St7API.DLL" (ByVal uID As Int32, ByVal LayoutID As Int32) As Int32
    Declare Ansi Function St7NewCreepDefinition Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal CreepDefinitionName As String) As Int32
    Declare Ansi Function St7GetCreepDefinitionName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal CreepDefinitionName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetCreepDefinitionName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal CreepDefinitionName As String) As Int32
    Declare Ansi Function St7GetCreepLaw Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef CreepLaw As Int32) As Int32
    Declare Ansi Function St7SetCreepLaw Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal CreepLaw As Int32) As Int32
    Declare Ansi Function St7GetCreepBasicData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepBasicData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7EnableCreepUserTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7DisableCreepUserTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetCreepUserTableState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetCreepUserTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepUserTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetCreepHardeningType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetCreepHardeningType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetCreepTimeUnit Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetCreepTimeUnit Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetCreepTemperatureInclude Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Include As Byte) As Int32
    Declare Ansi Function St7SetCreepTemperatureInclude Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal Include As Byte) As Int32
    Declare Ansi Function St7GetCreepConcreteHyperbolicData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepConcreteHyperbolicData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetCreepConcreteViscoChainData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepConcreteViscoChainData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7EnableCreepConcreteUserTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7DisableCreepConcreteUserTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetCreepConcreteUserTableState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetCreepConcreteUserTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepConcreteUserTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetCreepConcreteFunctionType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef FunctionType As Int32) As Int32
    Declare Ansi Function St7SetCreepConcreteFunctionType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal FunctionType As Int32) As Int32
    Declare Ansi Function St7GetCreepConcreteLoadingAge Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef LoadingAge As Double) As Int32
    Declare Ansi Function St7SetCreepConcreteLoadingAge Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal LoadingAge As Double) As Int32
    Declare Ansi Function St7GetCreepConcreteLoadingTimeUnit Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetCreepConcreteLoadingTimeUnit Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetCreepConcreteShrinkageType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef ShrinkageType As Int32) As Int32
    Declare Ansi Function St7SetCreepConcreteShrinkageType Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal ShrinkageType As Int32) As Int32
    Declare Ansi Function St7GetCreepConcreteShrinkageFormulaData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepConcreteShrinkageFormulaData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetCreepConcreteShrinkageTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7SetCreepConcreteShrinkageTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetCreepConcreteTemperatureData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepConcreteTemperatureData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetCreepConcreteCementCuringData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetCreepConcreteCementCuringData Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7DeleteCreepDefinition Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32) As Int32
    Declare Ansi Function St7NewLoadPathTemplate Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal LoadPathTemplateName As String) As Int32
    Declare Ansi Function St7GetLoadPathTemplateName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal LoadPathTemplateName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLoadPathTemplateName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal LoadPathTemplateName As String) As Int32
    Declare Ansi Function St7GetLoadPathTemplateParameters Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLoadPathTemplateParameters Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetLoadPathTemplateLaneFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Lane As Int32, ByRef Factor As Double) As Int32
    Declare Ansi Function St7SetLoadPathTemplateLaneFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Lane As Int32, ByVal Factor As Double) As Int32
    Declare Ansi Function St7AddLoadPathTemplateVehicle Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32) As Int32
    Declare Ansi Function St7GetLoadPathTemplateVehicleName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal LoadPathTemplateVehicleName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLoadPathTemplateVehicleName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal LoadPathTemplateVehicleName As String) As Int32
    Declare Ansi Function St7InsertLoadPathTemplateVehicle Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32) As Int32
    Declare Ansi Function St7CloneLoadPathTemplateVehicle Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32) As Int32
    Declare Ansi Function St7DeleteLoadPathTemplateVehicle Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32) As Int32
    Declare Ansi Function St7GetNumLoadPathTemplateVehicles Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByRef NumVehicles As Int32) As Int32
    Declare Ansi Function St7GetLoadPathTemplateVehicleData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLoadPathTemplateVehicleData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7EnableLoadPathTemplateVehicleLane Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Lane As Int32) As Int32
    Declare Ansi Function St7DisableLoadPathTemplateVehicleLane Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Lane As Int32) As Int32
    Declare Ansi Function St7GetLoadPathTemplateVehicleLaneState Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Lane As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7AddLoadPathTemplatePointForce Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32) As Int32
    Declare Ansi Function St7InsertLoadPathTemplatePointForce Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7DeleteLoadPathTemplatePointForce Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetNumLoadPathTemplatePointForces Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByRef NumPointForces As Int32) As Int32
    Declare Ansi Function St7GetLoadPathTemplatePointForceData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLoadPathTemplatePointForceData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7AddLoadPathTemplateDistributedForce Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32) As Int32
    Declare Ansi Function St7InsertLoadPathTemplateDistributedForce Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7DeleteLoadPathTemplateDistributedForce Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetNumLoadPathTemplateDistributedForces Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByRef NumDistributedForces As Int32) As Int32
    Declare Ansi Function St7GetLoadPathTemplateDistributedForceData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLoadPathTemplateDistributedForceData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7AddLoadPathTemplateHeatSource Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32) As Int32
    Declare Ansi Function St7InsertLoadPathTemplateHeatSource Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7DeleteLoadPathTemplateHeatSource Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetNumLoadPathTemplateHeatSources Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByRef NumHeatSources As Int32) As Int32
    Declare Ansi Function St7GetLoadPathTemplateHeatSourceData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLoadPathTemplateHeatSourceData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetLoadPathTemplateVehicleSet Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal LoadPathTemplateVehicleSet As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLoadPathTemplateVehicleSet Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal Vehicle As Int32, ByVal LoadPathTemplateVehicleSet As String) As Int32
    Declare Ansi Function St7DeleteLoadPathTemplate Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32) As Int32
    Declare Ansi Function St7SetLoadPathTemplateCentrifugalData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal K0 As String, ByVal K1 As String, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetLoadPathTemplateCentrifugalData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal K0 As String, ByVal K1 As String, ByVal MaxStringLen As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNumLibraries Lib "St7API.DLL" (ByVal uID As Int32, ByVal LibraryType As Int32, ByRef NumLibraries As Int32) As Int32
    Declare Ansi Function St7GetLibraryName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LibraryType As Int32, ByVal LibraryID As Int32, ByVal LibraryName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetLibraryID Lib "St7API.DLL" (ByVal uID As Int32, ByVal LibraryType As Int32, ByVal LibraryName As String, ByRef LibraryID As Int32) As Int32
    Declare Ansi Function St7GetNumLibraryItems Lib "St7API.DLL" (ByVal uID As Int32, ByVal LibraryType As Int32, ByVal LibraryID As Int32, ByRef NumItems As Int32) As Int32
    Declare Ansi Function St7GetLibraryItemName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LibraryType As Int32, ByVal LibraryID As Int32, ByVal ItemID As Int32, ByVal ItemName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetLibraryItemID Lib "St7API.DLL" (ByVal uID As Int32, ByVal LibraryType As Int32, ByVal LibraryID As Int32, ByVal ItemName As String, ByRef ItemID As Int32) As Int32
    Declare Ansi Function St7AssignLibraryMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByVal LibraryID As Int32, ByVal ItemID As Int32) As Int32
    Declare Ansi Function St7AssignLibraryComposite Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal LibraryID As Int32, ByVal ItemID As Int32) As Int32
    Declare Ansi Function St7AssignLibraryBeamSection Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal LibraryID As Int32, ByVal ItemID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7AssignLibraryCreepDefinition Lib "St7API.DLL" (ByVal uID As Int32, ByVal CreepID As Int32, ByVal LibraryID As Int32, ByVal ItemID As Int32) As Int32
    Declare Ansi Function St7AssignLibraryLoadPathTemplate Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathTemplateID As Int32, ByVal LibraryID As Int32, ByVal ItemID As Int32) As Int32
    Declare Ansi Function St7AssignLibraryReinforcementLayout Lib "St7API.DLL" (ByVal uID As Int32, ByVal LayoutID As Int32, ByVal LibraryID As Int32, ByVal ItemID As Int32) As Int32
    Declare Ansi Function St7NewTableType Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByVal NumEntries As Int32, ByVal TableName As String, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7DeleteTableType Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetTableTypeName Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByVal TableName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetTableID Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableName As String, ByVal TableType As Int32, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7GetNumTableTypeRows Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByRef NumRows As Int32) As Int32
    Declare Ansi Function St7GetTableTypeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByVal MaxRows As Int32, ByRef NumRows As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetTableTypeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByVal NumEntries As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetFrequencyTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByRef FreqType As Int32) As Int32
    Declare Ansi Function St7SetFrequencyTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByVal FreqType As Int32) As Int32
    Declare Ansi Function St7GetTimeTableUnits Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByRef UnitType As Int32) As Int32
    Declare Ansi Function St7SetTimeTableUnits Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByVal UnitType As Int32) As Int32
    Declare Ansi Function St7ConvertTimeTableUnits Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal TableID As Int32, ByVal UnitType As Int32) As Int32
    Declare Ansi Function St7GetFrequencyPeriodTableUnits Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByRef UnitType As Int32) As Int32
    Declare Ansi Function St7SetFrequencyPeriodTableUnits Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByVal UnitType As Int32) As Int32
    Declare Ansi Function St7GetNumTables Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByRef NumTables As Int32, ByRef MaxTableNum As Int32) As Int32
    Declare Ansi Function St7GetTableInfoByIndex Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableType As Int32, ByVal Index As Int32, ByRef TableID As Int32, ByVal TableName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7EnableLSALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32) As Int32
    Declare Ansi Function St7DisableLSALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32) As Int32
    Declare Ansi Function St7GetLSALoadCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7EnableLSAInitialPCGFile Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DisableLSAInitialPCGFile Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7GetLSAInitialPCGFileState Lib "St7API.DLL" (ByVal uID As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetLSAInitialPCGFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GetLSAInitialPCGFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLBAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetLBAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLBANumModes Lib "St7API.DLL" (ByVal uID As Int32, ByVal NumModes As Int32) As Int32
    Declare Ansi Function St7GetLBANumModes Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumModes As Int32) As Int32
    Declare Ansi Function St7SetLBAShift Lib "St7API.DLL" (ByVal uID As Int32, ByVal Shift As Double) As Int32
    Declare Ansi Function St7GetLBAShift Lib "St7API.DLL" (ByVal uID As Int32, ByRef Shift As Double) As Int32
    Declare Ansi Function St7EnableLIALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32) As Int32
    Declare Ansi Function St7DisableLIALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32) As Int32
    Declare Ansi Function St7GetLIALoadCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetNLAStagedAnalysis Lib "St7API.DLL" (ByVal uID As Int32, ByVal StagedAnalysis As Byte) As Int32
    Declare Ansi Function St7GetNLAStagedAnalysis Lib "St7API.DLL" (ByVal uID As Int32, ByRef StagedAnalysis As Byte) As Int32
    Declare Ansi Function St7EnableNLAStage Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32) As Int32
    Declare Ansi Function St7DisableNLAStage Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32) As Int32
    Declare Ansi Function St7GetNLAStageState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7AddNLAIncrement Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal IncName As String) As Int32
    Declare Ansi Function St7InsertNLAIncrement Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal Increment As Int32, ByVal IncName As String) As Int32
    Declare Ansi Function St7DeleteNLAIncrement Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal Increment As Int32) As Int32
    Declare Ansi Function St7GetNumNLAIncrements Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByRef NumIncrements As Int32) As Int32
    Declare Ansi Function St7SetNLALoadIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByVal dFactor As Double) As Int32
    Declare Ansi Function St7SetNLAFreedomIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByVal dFactor As Double) As Int32
    Declare Ansi Function St7GetNLALoadIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByRef dFactor As Double) As Int32
    Declare Ansi Function St7GetNLAFreedomIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByRef dFactor As Double) As Int32
    Declare Ansi Function St7EnableNLALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableNLALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7EnableNLAFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableNLAFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNLALoadCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetNLAFreedomCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetNLAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNLAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetQSAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetQSAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetNFAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNFAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7EnableNFANonStructuralMassCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableNFANonStructuralMassCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNFANonStructuralMassCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetNFANumModes Lib "St7API.DLL" (ByVal uID As Int32, ByVal NumModes As Int32) As Int32
    Declare Ansi Function St7GetNFANumModes Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumModes As Int32) As Int32
    Declare Ansi Function St7SetNFAShift Lib "St7API.DLL" (ByVal uID As Int32, ByVal Shift As Double) As Int32
    Declare Ansi Function St7GetNFAShift Lib "St7API.DLL" (ByVal uID As Int32, ByRef Shift As Double) As Int32
    Declare Ansi Function St7SetNFAModeParticipationCalculate Lib "St7API.DLL" (ByVal uID As Int32, ByVal Calculate As Byte) As Int32
    Declare Ansi Function St7GetNFAModeParticipationCalculate Lib "St7API.DLL" (ByVal uID As Int32, ByRef Calculate As Byte) As Int32
    Declare Ansi Function St7SetNFAModeParticipationVectors Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNFAModeParticipationVectors Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetHRARange Lib "St7API.DLL" (ByVal uID As Int32, ByVal NumSteps As Int32, ByVal F1 As Double, ByVal F2 As Double, ByVal AutoInsert As Byte) As Int32
    Declare Ansi Function St7GetHRARange Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumSteps As Int32, ByRef F1 As Double, ByRef F2 As Double, ByRef AutoInsert As Byte) As Int32
    Declare Ansi Function St7SetHRAResultType Lib "St7API.DLL" (ByVal uID As Int32, ByVal lType As Int32) As Int32
    Declare Ansi Function St7GetHRAResultType Lib "St7API.DLL" (ByVal uID As Int32, ByRef lType As Int32) As Int32
    Declare Ansi Function St7SetHRABaseVector Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetHRABaseVector Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetHRALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal TableID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetHRALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef TableID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7AddSRALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7InsertSRALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7DeleteSRALoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetNumSRALoadCases Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumCases As Int32) As Int32
    Declare Ansi Function St7SetSRALoadCaseTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal CaseNum As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetSRALoadCaseTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal CaseNum As Int32, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7AddSRADirectionVector Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7InsertSRADirectionVector Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7DeleteSRADirectionVector Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetNumSRADirectionVectors Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumCases As Int32) As Int32
    Declare Ansi Function St7SetSRADirectionVectorTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetSRADirectionVectorTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7SetSRADirectionVectorFactors Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetSRADirectionVectorFactors Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetSRAResultModal Lib "St7API.DLL" (ByVal uID As Int32, ByVal Modal As Byte) As Int32
    Declare Ansi Function St7SetSRAResultSRSS Lib "St7API.DLL" (ByVal uID As Int32, ByVal SRSS As Byte) As Int32
    Declare Ansi Function St7SetSRAResultCQC Lib "St7API.DLL" (ByVal uID As Int32, ByVal CQC As Byte) As Int32
    Declare Ansi Function St7SetSRAType Lib "St7API.DLL" (ByVal uID As Int32, ByVal SpectrumType As Int32) As Int32
    Declare Ansi Function St7SetSRAResultsSign Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultsSign As Int32) As Int32
    Declare Ansi Function St7SetLTAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetLTAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLTAMethod Lib "St7API.DLL" (ByVal uID As Int32, ByVal Method As Int32) As Int32
    Declare Ansi Function St7GetLTAMethod Lib "St7API.DLL" (ByVal uID As Int32, ByRef Method As Int32) As Int32
    Declare Ansi Function St7SetLTASolutionType Lib "St7API.DLL" (ByVal uID As Int32, ByVal SolutionType As Int32) As Int32
    Declare Ansi Function St7GetLTASolutionType Lib "St7API.DLL" (ByVal uID As Int32, ByRef SolutionType As Int32) As Int32
    Declare Ansi Function St7SetNTAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNTAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetNTALoadPositionTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal TableNum As Int32, ByVal UCSId As Int32, ByVal Axis As Int32) As Int32
    Declare Ansi Function St7GetNTALoadPositionTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef TableNum As Int32, ByRef UCSId As Int32, ByRef Axis As Int32) As Int32
    Declare Ansi Function St7SetNTAFreedomPositionTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal TableNum As Int32, ByVal UCSId As Int32, ByVal Axis As Int32) As Int32
    Declare Ansi Function St7GetNTAFreedomPositionTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef TableNum As Int32, ByRef UCSId As Int32, ByRef Axis As Int32) As Int32
    Declare Ansi Function St7EnableHeatLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableHeatLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetHeatLoadCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetTHAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetTHAInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetTHATemperatureLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetTHATemperatureLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByRef CaseNum As Int32) As Int32
    Declare Ansi Function St7GetModalLoadType Lib "St7API.DLL" (ByVal uID As Int32, ByRef lType As Int32) As Int32
    Declare Ansi Function St7SetModalLoadType Lib "St7API.DLL" (ByVal uID As Int32, ByVal lType As Int32) As Int32
    Declare Ansi Function St7GetModalNodeReactionType Lib "St7API.DLL" (ByVal uID As Int32, ByRef rType As Int32) As Int32
    Declare Ansi Function St7SetModalNodeReactionType Lib "St7API.DLL" (ByVal uID As Int32, ByVal rType As Int32) As Int32
    Declare Ansi Function St7SetModalSuperpositionFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GetModalSuperpositionFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetNumModesInModalFile Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumModes As Int32) As Int32
    Declare Ansi Function St7EnableMode Lib "St7API.DLL" (ByVal uID As Int32, ByVal ModeNum As Int32) As Int32
    Declare Ansi Function St7DisableMode Lib "St7API.DLL" (ByVal uID As Int32, ByVal ModeNum As Int32) As Int32
    Declare Ansi Function St7SetModeDampingRatio Lib "St7API.DLL" (ByVal uID As Int32, ByVal ModeNum As Int32, ByVal Ratio As Double) As Int32
    Declare Ansi Function St7GetModeDampingRatio Lib "St7API.DLL" (ByVal uID As Int32, ByVal ModeNum As Int32, ByRef Ratio As Double) As Int32
    Declare Ansi Function St7SetTransientInitialConditionsType Lib "St7API.DLL" (ByVal uID As Int32, ByVal InitialType As Int32) As Int32
    Declare Ansi Function St7GetTransientInitialConditionsType Lib "St7API.DLL" (ByVal uID As Int32, ByRef InitialType As Int32) As Int32
    Declare Ansi Function St7SetTransientInitialConditionsVectors Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetTransientInitialConditionsVectors Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetTransientInitialConditionsNodalVelocity Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetTransientInitialConditionsNodalVelocity Lib "St7API.DLL" (ByVal uID As Int32, ByRef CaseNum As Int32) As Int32
    Declare Ansi Function St7GetTransientBaseVector Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetTransientBaseVector Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetTransientBaseVelocity Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetTransientBaseVelocity Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetTransientBaseTables Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7SetTransientBaseTables Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32) As Int32
    Declare Ansi Function St7GetTransientBaseResults Lib "St7API.DLL" (ByVal uID As Int32, ByRef Logicals As Byte) As Int32
    Declare Ansi Function St7SetTransientBaseResults Lib "St7API.DLL" (ByVal uID As Int32, ByRef Logicals As Byte) As Int32
    Declare Ansi Function St7AddTransientNodeHistoryCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32) As Int32
    Declare Ansi Function St7InsertTransientNodeHistoryCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7DeleteTransientNodeHistoryCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetNumTransientNodeHistoryCases Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumCases As Int32) As Int32
    Declare Ansi Function St7SetTransientNodeHistoryCaseData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByRef Logicals As Byte) As Int32
    Declare Ansi Function St7GetTransientNodeHistoryCaseData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByRef Logicals As Byte) As Int32
    Declare Ansi Function St7SetTransientTemperatureInputType Lib "St7API.DLL" (ByVal uID As Int32, ByVal InputType As Int32) As Int32
    Declare Ansi Function St7SetTransientHeatFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal RefTemp As Double) As Int32
    Declare Ansi Function St7GetTransientHeatFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32, ByRef RefTemp As Double) As Int32
    Declare Ansi Function St7EnableTransientLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7EnableTransientFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableTransientLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableTransientFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetTransientLoadCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetTransientFreedomCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetTransientLoadTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal TableNum As Int32) As Int32
    Declare Ansi Function St7GetTransientLoadTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef TableNum As Int32) As Int32
    Declare Ansi Function St7SetTransientFreedomTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal TableNum As Int32) As Int32
    Declare Ansi Function St7GetTransientFreedomTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef TableNum As Int32) As Int32
    Declare Ansi Function St7GetNumTimeStepRows Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumRows As Int32) As Int32
    Declare Ansi Function St7SetNumTimeStepRows Lib "St7API.DLL" (ByVal uID As Int32, ByVal NumRows As Int32) As Int32
    Declare Ansi Function St7GetTimeStepData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Row As Int32, ByRef NumSteps As Int32, ByRef SaveEvery As Int32, ByRef TimeStep As Double) As Int32
    Declare Ansi Function St7SetTimeStepData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Row As Int32, ByVal NumSteps As Int32, ByVal SaveEvery As Int32, ByVal TimeStep As Double) As Int32
    Declare Ansi Function St7SetTimeStepUnit Lib "St7API.DLL" (ByVal uID As Int32, ByVal TimeUnit As Int32) As Int32
    Declare Ansi Function St7GetTimeStepUnit Lib "St7API.DLL" (ByVal uID As Int32, ByRef TimeUnit As Int32) As Int32
    Declare Ansi Function St7EnableMovingLoad Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathID As Int32) As Int32
    Declare Ansi Function St7DisableMovingLoad Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathID As Int32) As Int32
    Declare Ansi Function St7GetMovingLoadState Lib "St7API.DLL" (ByVal uID As Int32, ByVal LoadPathID As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetSolverHeatNonlinear Lib "St7API.DLL" (ByVal uID As Int32, ByVal Nonlinear As Byte) As Int32
    Declare Ansi Function St7SetSolverScheme Lib "St7API.DLL" (ByVal uID As Int32, ByVal Solver As Int32) As Int32
    Declare Ansi Function St7GetSolverScheme Lib "St7API.DLL" (ByVal uID As Int32, ByRef Solver As Int32) As Int32
    Declare Ansi Function St7SetSolverSort Lib "St7API.DLL" (ByVal uID As Int32, ByVal Sort As Int32) As Int32
    Declare Ansi Function St7GetSolverSort Lib "St7API.DLL" (ByVal uID As Int32, ByRef Sort As Int32) As Int32
    Declare Ansi Function St7SetSolverTreeStartNumber Lib "St7API.DLL" (ByVal uID As Int32, ByVal Start As Int32) As Int32
    Declare Ansi Function St7GetSolverTreeStartNumber Lib "St7API.DLL" (ByVal uID As Int32, ByRef Start As Int32) As Int32
    Declare Ansi Function St7SetSolverActiveStage Lib "St7API.DLL" (ByVal uID As Int32, ByVal Stage As Int32) As Int32
    Declare Ansi Function St7GetSolverActiveStage Lib "St7API.DLL" (ByVal uID As Int32, ByRef Stage As Int32) As Int32
    Declare Ansi Function St7SetSolverTemperatureDependence Lib "St7API.DLL" (ByVal uID As Int32, ByVal TempType As Int32) As Int32
    Declare Ansi Function St7GetSolverTemperatureDependence Lib "St7API.DLL" (ByVal uID As Int32, ByRef TempType As Int32) As Int32
    Declare Ansi Function St7SetSolverLoadCaseTemperatureDependence Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetSolverLoadCaseTemperatureDependence Lib "St7API.DLL" (ByVal uID As Int32, ByRef CaseNum As Int32) As Int32
    Declare Ansi Function St7SetSolverFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetSolverFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByRef CaseNum As Int32) As Int32
    Declare Ansi Function St7SetDampingType Lib "St7API.DLL" (ByVal uID As Int32, ByVal DampType As Int32) As Int32
    Declare Ansi Function St7GetDampingType Lib "St7API.DLL" (ByVal uID As Int32, ByRef DampType As Int32) As Int32
    Declare Ansi Function St7SetRayleighFactors Lib "St7API.DLL" (ByVal uID As Int32, ByVal RayleighMode As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetRayleighFactors Lib "St7API.DLL" (ByVal uID As Int32, ByRef RayleighMode As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetSoilFluidOptions Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetSoilFluidOptions Lib "St7API.DLL" (ByVal uID As Int32, ByRef CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetSturmCheck Lib "St7API.DLL" (ByVal uID As Int32, ByVal DoSturm As Byte) As Int32
    Declare Ansi Function St7GetSturmCheck Lib "St7API.DLL" (ByVal uID As Int32, ByRef DoSturm As Byte) As Int32
    Declare Ansi Function St7SetSolverNonlinearGeometry Lib "St7API.DLL" (ByVal uID As Int32, ByVal NonlinearGeometry As Byte) As Int32
    Declare Ansi Function St7GetSolverNonlinearGeometry Lib "St7API.DLL" (ByVal uID As Int32, ByRef NonlinearGeometry As Byte) As Int32
    Declare Ansi Function St7SetSolverNonlinearMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByVal NonlinearMaterial As Byte) As Int32
    Declare Ansi Function St7GetSolverNonlinearMaterial Lib "St7API.DLL" (ByVal uID As Int32, ByRef NonlinearMaterial As Byte) As Int32
    Declare Ansi Function St7SetSolverCreep Lib "St7API.DLL" (ByVal uID As Int32, ByVal Creep As Byte) As Int32
    Declare Ansi Function St7GetSolverCreep Lib "St7API.DLL" (ByVal uID As Int32, ByRef Creep As Byte) As Int32
    Declare Ansi Function St7SetSolverIncludeKG Lib "St7API.DLL" (ByVal uID As Int32, ByVal IncludeKG As Byte) As Int32
    Declare Ansi Function St7GetSolverIncludeKG Lib "St7API.DLL" (ByVal uID As Int32, ByRef IncludeKG As Byte) As Int32
    Declare Ansi Function St7SetSolverStressStiffening Lib "St7API.DLL" (ByVal uID As Int32, ByVal AddStressStiffening As Byte) As Int32
    Declare Ansi Function St7GetSolverStressStiffening Lib "St7API.DLL" (ByVal uID As Int32, ByRef AddStressStiffening As Byte) As Int32
    Declare Ansi Function St7SetEntityResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal Result As Int32, ByVal State As Int32) As Int32
    Declare Ansi Function St7GetEntityResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal Result As Int32, ByRef State As Int32) As Int32
    Declare Ansi Function St7SetResultSurfaceBricksOnly Lib "St7API.DLL" (ByVal uID As Int32, ByVal State As Int32) As Int32
    Declare Ansi Function St7GetResultSurfaceBricksOnly Lib "St7API.DLL" (ByVal uID As Int32, ByRef State As Int32) As Int32
    Declare Ansi Function St7SetResultLimit Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal State As Int32, ByVal Limit As Double) As Int32
    Declare Ansi Function St7GetResultLimit Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByRef State As Int32, ByRef Limit As Double) As Int32
    Declare Ansi Function St7EnableResultGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7DisableResultGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7GetResultGroupState Lib "St7API.DLL" (ByVal uID As Int32, ByVal GroupID As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7EnableResultProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7DisableResultProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32) As Int32
    Declare Ansi Function St7GetResultPropertyState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal PropNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetResultFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7SetResultLogFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal LogName As String) As Int32
    Declare Ansi Function St7SetStaticRestartFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GetStaticRestartFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetDynamicRestartFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GetDynamicRestartFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetQuasiStaticRestartFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GetQuasiStaticRestartFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetNodeHistoryFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GetNodeHistoryFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7EnableSaveRestart Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DisableSaveRestart Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7EnableSaveLastRestartStep Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DisableSaveLastRestartStep Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7EnableAutoAssignPathDivisions Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7DisableAutoAssignPathDivisions Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7SetSolverDefaultsLogical Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByVal pValue As Byte) As Int32
    Declare Ansi Function St7GetSolverDefaultsLogical Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByRef pValue As Byte) As Int32
    Declare Ansi Function St7SetSolverDefaultsInteger Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByVal pValue As Int32) As Int32
    Declare Ansi Function St7GetSolverDefaultsInteger Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByRef pValue As Int32) As Int32
    Declare Ansi Function St7SetSolverDefaultsDouble Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByVal pValue As Double) As Int32
    Declare Ansi Function St7GetSolverDefaultsDouble Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByRef pValue As Double) As Int32
    Declare Ansi Function St7RunSolver Lib "St7API.DLL" (ByVal uID As Int32, ByVal Solver As Int32, ByVal Mode As Int32, ByVal Wait As Int32) As Int32
    Declare Ansi Function St7RunSolverProcess Lib "St7API.DLL" (ByVal uID As Int32, ByVal Solver As Int32, ByVal Mode As Int32, ByVal Wait As Int32, ByRef ProcessID As Int32) As Int32
    Declare Ansi Function St7CheckSolverRunning Lib "St7API.DLL" (ByVal ProcessID As Int32, ByRef IsRunning As Byte) As Int32
    Declare Ansi Function St7GetResultCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetResultFreedomCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetResultCaseConvergence Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Converged As Byte) As Int32
    Declare Ansi Function St7GetResultCaseTime Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Time As Double) As Int32
    Declare Ansi Function St7GetResultCaseFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Factor As Double) As Int32
    Declare Ansi Function St7GetFrequency Lib "St7API.DLL" (ByVal uID As Int32, ByVal Mode As Int32, ByRef Freq As Double) As Int32
    Declare Ansi Function St7GetModalResultsNFA Lib "St7API.DLL" (ByVal uID As Int32, ByVal Mode As Int32, ByRef ModalRes As Double) As Int32
    Declare Ansi Function St7GetInertiaReliefResults Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef InertiaRes As Double) As Int32
    Declare Ansi Function St7GetBuckFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Mode As Int32, ByRef Fact As Double) As Int32
    Declare Ansi Function St7GetNodeResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal NodeNum As Int32, ByVal ResultCase As Int32, ByRef NodeRes As Double) As Int32
    Declare Ansi Function St7GetNodeResultUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal UCSId As Int32, ByVal NodeNum As Int32, ByVal ResultCase As Int32, ByRef NodeRes As Double) As Int32
    Declare Ansi Function St7GetBeamResultArray Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal BeamNum As Int32, ByVal MinStations As Int32, ByVal ResultCase As Int32, ByRef NumStations As Int32, ByRef NumColumns As Int32, ByRef BeamPos As Double, ByRef BeamRes As Double) As Int32
    Declare Ansi Function St7GetBeamResultArrayPos Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal BeamNum As Int32, ByVal ResultCase As Int32, ByVal NumStations As Int32, ByRef BeamPos As Double, ByRef NumColumns As Int32, ByRef BeamRes As Double) As Int32
    Declare Ansi Function St7GetBeamResultEndPos Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal BeamNum As Int32, ByVal ResultCase As Int32, ByRef NumColumns As Int32, ByRef BeamRes As Double) As Int32
    Declare Ansi Function St7GetBeamResultSinglePos Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal BeamNum As Int32, ByVal ResultCase As Int32, ByVal Position As Double, ByRef NumColumns As Int32, ByRef BeamRes As Double) As Int32
    Declare Ansi Function St7GetBeamReleaseResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal ResultCase As Int32, ByRef BeamReleased As Byte, ByRef ReleaseValue As Double) As Int32
    Declare Ansi Function St7GetPlateResultArray Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal PlateNum As Int32, ByVal ResultCase As Int32, ByVal SampleLocation As Int32, ByVal Surface As Int32, ByVal Layer As Int32, ByRef NumPoints As Int32, ByRef NumColumns As Int32, ByRef PlateResult As Double) As Int32
    Declare Ansi Function St7SetPlateResultMaxJunctionAngle Lib "St7API.DLL" (ByVal uID As Int32, ByVal MaxJunctionAngle As Double) As Int32
    Declare Ansi Function St7GetPlateResultMaxJunctionAngle Lib "St7API.DLL" (ByVal uID As Int32, ByRef MaxJunctionAngle As Double) As Int32
    Declare Ansi Function St7SetPlateResultUserEquation Lib "St7API.DLL" (ByVal uID As Int32, ByVal Equation As String, ByVal TrigType As Int32) As Int32
    Declare Ansi Function St7GetPlateResultUserEquation Lib "St7API.DLL" (ByVal uID As Int32, ByVal Equation As String, ByVal MaxStringLen As Int32, ByRef TrigType As Int32) As Int32
    Declare Ansi Function St7GetPlateResultGaussPoints Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal ResultCase As Int32, ByRef NumGauss As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBrickResultArray Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal BrickNum As Int32, ByVal ResultCase As Int32, ByVal SampleLocation As Int32, ByRef NumPoints As Int32, ByRef NumColumns As Int32, ByRef BrickRes As Double) As Int32
    Declare Ansi Function St7SetBrickResultUserEquation Lib "St7API.DLL" (ByVal uID As Int32, ByVal Equation As String, ByVal TrigType As Int32) As Int32
    Declare Ansi Function St7GetBrickResultUserEquation Lib "St7API.DLL" (ByVal uID As Int32, ByVal Equation As String, ByVal MaxStringLen As Int32, ByRef TrigType As Int32) As Int32
    Declare Ansi Function St7GetBrickResultGaussPoints Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal ResultCase As Int32, ByRef NumGauss As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetNumLSACombinations Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumCases As Int32) As Int32
    Declare Ansi Function St7GetLSACombinationName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLSACombinationName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7GetLSACombinationSpectralName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLSACombinationSpectralName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7AddLSACombination Lib "St7API.DLL" (ByVal uID As Int32, ByVal IncName As String) As Int32
    Declare Ansi Function St7InsertLSACombination Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal IncName As String) As Int32
    Declare Ansi Function St7DeleteLSACombination Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7SetLSACombinationFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal LType As Int32, ByVal Pos As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32, ByVal Factor As Double) As Int32
    Declare Ansi Function St7GetLSACombinationFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal LType As Int32, ByVal Pos As Int32, ByVal LCaseNum As Int32, ByVal FCaseNum As Int32, ByRef Factor As Double) As Int32
    Declare Ansi Function St7GetNumEnvelopes Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumLimitEnvelopes As Int32, ByRef NumCombinationEnvelopes As Int32, ByRef NumFactorsEnvelopes As Int32) As Int32
    Declare Ansi Function St7AddLimitEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7InsertLimitEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7DeleteLimitEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32) As Int32
    Declare Ansi Function St7EnableLimitEnvelopeCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableLimitEnvelopeCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetLimitEnvelopeCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetLimitEnvelopeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByRef EnvType As Int32, ByVal EnvName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLimitEnvelopeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7AddCombinationEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7InsertCombinationEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7DeleteCombinationEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32) As Int32
    Declare Ansi Function St7GetCombinationEnvelopeCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal CaseNum As Int32, ByRef State As Int32) As Int32
    Declare Ansi Function St7SetCombinationEnvelopeCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal CaseNum As Int32, ByVal State As Int32) As Int32
    Declare Ansi Function St7GetCombinationEnvelopeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByRef EnvType As Int32, ByVal EnvName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetCombinationEnvelopeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7AddFactorsEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7InsertFactorsEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7DeleteFactorsEnvelope Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32) As Int32
    Declare Ansi Function St7GetFactorsEnvelopeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByRef EnvType As Int32, ByVal EnvName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetFactorsEnvelopeData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal EnvType As Int32, ByVal EnvName As String) As Int32
    Declare Ansi Function St7AddFactorsEnvelopeCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32) As Int32
    Declare Ansi Function St7InsertFactorsEnvelopeCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7DeleteFactorsEnvelopeCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetFactorsEnvelopeCaseData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetFactorsEnvelopeCaseData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Envelope As Int32, ByVal Pos As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7AddFactorsEnvelopeSet Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7InsertFactorsEnvelopeSet Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7DeleteFactorsEnvelopeSet Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7GetNumFactorsEnvelopeSets Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumSets As Int32) As Int32
    Declare Ansi Function St7GetFactorsEnvelopeSetData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByRef SetType As Int32, ByVal SetName As String, ByVal SetGroup As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetFactorsEnvelopeSetData Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal SetType As Int32, ByVal SetName As String, ByVal SetGroup As String) As Int32
    Declare Ansi Function St7GetResultFileCombTargetFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetResultFileCombTargetFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7AddResultFileCombFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7DeleteResultFileCombFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileNum As Int32) As Int32
    Declare Ansi Function St7GetResultFileCombFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileNum As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetResultFileCombFileName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileNum As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7AddResultFileCombCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7DeleteResultFileCombCase Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7GetResultFileCombCaseData Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileNum As Int32, ByVal Pos As Int32, ByRef CaseNum As Int32, ByRef Factor As Double) As Int32
    Declare Ansi Function St7SetResultFileCombCaseData Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileNum As Int32, ByVal Pos As Int32, ByVal CaseNum As Int32, ByVal Factor As Double) As Int32
    Declare Ansi Function St7GetResultFileCombCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal CaseName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetResultFileCombCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7GenerateResultFileComb Lib "St7API.DLL" (ByVal uID As Int32, ByVal Method As Int32) As Int32
    Declare Ansi Function St7UpdateResultFileComb Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7GenerateHRATimeHistory Lib "St7API.DLL" (ByVal uID As Int32, ByVal StartTime As Double, ByVal EndTime As Double, ByVal NumSteps As Int32) As Int32
    Declare Ansi Function St7NewResFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal ResultType As Int32) As Int32
    Declare Ansi Function St7OpenResFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String) As Int32
    Declare Ansi Function St7CloseResFile Lib "St7API.DLL" (ByVal uID As Int32) As Int32
    Declare Ansi Function St7SetResFileDescription Lib "St7API.DLL" (ByVal uID As Int32, ByVal Name As String) As Int32
    Declare Ansi Function St7GetResFileDescription Lib "St7API.DLL" (ByVal uID As Int32, ByVal Name As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetResFileNumCases Lib "St7API.DLL" (ByVal uID As Int32, ByVal NumCases As Int32) As Int32
    Declare Ansi Function St7SetResFileCaseName Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal CaseName As String) As Int32
    Declare Ansi Function St7AssociateResFileCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal LoadCase As Int32, ByVal FreedomCase As Int32) As Int32
    Declare Ansi Function St7AssociateResFileStage Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal StageNum As Int32) As Int32
    Declare Ansi Function St7SetResFileMode Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Mode As Double) As Int32
    Declare Ansi Function St7GetResFileMode Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Mode As Double) As Int32
    Declare Ansi Function St7SetResFileTime Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Time As Double) As Int32
    Declare Ansi Function St7GetResFileTime Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Time As Double) As Int32
    Declare Ansi Function St7SetResFileTimeUnit Lib "St7API.DLL" (ByVal uID As Int32, ByVal TimeUnit As Int32) As Int32
    Declare Ansi Function St7GetResFileTimeUnit Lib "St7API.DLL" (ByVal uID As Int32, ByRef TimeUnit As Int32) As Int32
    Declare Ansi Function St7SetResFileQuantity Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Entity As Int32, ByVal Quantity As Int32) As Int32
    Declare Ansi Function St7ClearResFileQuantity Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Entity As Int32, ByVal Quantity As Int32) As Int32
    Declare Ansi Function St7GetResFileQuantity Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Entity As Int32, ByVal Quantity As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7SetResFileNodeResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Node As Int32, ByVal Quantity As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetResFileNodeResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Node As Int32, ByVal Quantity As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetResFileBeamResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Beam As Int32, ByVal Quantity As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetResFileBeamResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Beam As Int32, ByVal Quantity As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetResFileBeamStations Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Stations As Int32) As Int32
    Declare Ansi Function St7GetResFileBeamStations Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef Stations As Int32) As Int32
    Declare Ansi Function St7SetResFilePlateResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Plate As Int32, ByVal Quantity As Int32, ByVal NonlinearMaterial As Byte, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetResFilePlateResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Plate As Int32, ByVal Quantity As Int32, ByRef NonlinearMaterial As Byte, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetResFileBrickResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Brick As Int32, ByVal Quantity As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetResFileBrickResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Brick As Int32, ByVal Quantity As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7ToolAlignBeamAxes Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamAxis As Int32, ByVal BeamAxisType As Int32, ByVal UCSAxis As Int32, ByVal UCSId As Int32) As Int32
    Declare Ansi Function St7ToolAlignPlateAxes Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal PlateAxis As Int32, ByVal UCSAxis As Int32, ByVal UCSId As Int32) As Int32
    Declare Ansi Function St7ToolConvertPatchLoads Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByVal Overwrite As Byte) As Int32
    Declare Ansi Function St7ToolAttachParts Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7ToolPolygonToFace Lib "St7API.DLL" (ByVal uID As Int32, ByRef Integers As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7ZipMesh Lib "St7API.DLL" (ByVal uID As Int32, ByVal Tol As Double, ByVal TolType As Int32) As Int32
    Declare Ansi Function St7SetBeamSectionProperties Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7CalcBeamSectionProperties Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByVal ExactJ As Int32) As Int32
    Declare Ansi Function St7AddNonlinearIncrement Lib "St7API.DLL" (ByVal uID As Int32, ByVal Name As String) As Int32
    Declare Ansi Function St7InsertNonlinearIncrement Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal Name As String) As Int32
    Declare Ansi Function St7DeleteNonlinearIncrement Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7SetNonlinearLoadIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByVal Factor As Double) As Int32
    Declare Ansi Function St7SetNonlinearFreedomIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByVal Factor As Double) As Int32
    Declare Ansi Function St7GetNonlinearLoadIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByRef Factor As Double) As Int32
    Declare Ansi Function St7GetNonlinearFreedomIncrementFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal Increment As Int32, ByVal CaseNum As Int32, ByRef Factor As Double) As Int32
    Declare Ansi Function St7AddLoadCaseCombination Lib "St7API.DLL" (ByVal uID As Int32, ByVal Name As String) As Int32
    Declare Ansi Function St7InsertLoadCaseCombination Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32, ByVal Name As String) As Int32
    Declare Ansi Function St7DeleteLoadCaseCombination Lib "St7API.DLL" (ByVal uID As Int32, ByVal Pos As Int32) As Int32
    Declare Ansi Function St7SetLoadCaseCombinationFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal CombinationNum As Int32, ByVal CaseNum As Int32, ByVal Factor As Double) As Int32
    Declare Ansi Function St7GetLoadCaseCombinationFactor Lib "St7API.DLL" (ByVal uID As Int32, ByVal CombinationNum As Int32, ByVal CaseNum As Int32, ByRef Factor As Double) As Int32
    Declare Ansi Function St7EnableNonlinearLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableNonlinearLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7EnableNonlinearFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableNonlinearFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNonlinearLoadCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetNonlinearFreedomCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7EnableFrequencyNSMassCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableFrequencyNSMassCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetFrequencyNSMassCaseState Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef State As Byte) As Int32
    Declare Ansi Function St7GetBeamResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal BeamNum As Int32, ByVal MinStations As Int32, ByVal ResultCase As Int32, ByRef NumStations As Int32, ByRef NumColumns As Int32, ByRef BeamPos As Double, ByRef BeamRes As Double) As Int32
    Declare Ansi Function St7GetBeamForceResultPos Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal ResultCase As Int32, ByVal Position As Double, ByRef BeamRes As Double) As Int32
    Declare Ansi Function St7GetBeamResultPos Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal BeamNum As Int32, ByVal ResultCase As Int32, ByVal NumStations As Int32, ByRef BeamPos As Double, ByRef NumColumns As Int32, ByRef BeamRes As Double) As Int32
    Declare Ansi Function St7GetBeamDispResultPos Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal ResultCase As Int32, ByVal Position As Double, ByRef LocalDisp As Double, ByRef GlobalDisp As Double) As Int32
    Declare Ansi Function St7GetPlateResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal PlateNum As Int32, ByVal ResultCase As Int32, ByVal SampleLocation As Int32, ByVal Surface As Int32, ByRef NumPoints As Int32, ByRef NumColumns As Int32, ByRef PlateRes As Double) As Int32
    Declare Ansi Function St7GetPlateResultUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal UCSId As Int32, ByVal PlateNum As Int32, ByVal ResultCase As Int32, ByVal SampleLocation As Int32, ByVal Surface As Int32, ByRef NumPoints As Int32, ByRef NumColumns As Int32, ByRef PlateRes As Double) As Int32
    Declare Ansi Function St7GetBrickResult Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal ResultSubType As Int32, ByVal BrickNum As Int32, ByVal ResultCase As Int32, ByVal SampleLocation As Int32, ByRef NumPoints As Int32, ByRef NumColumns As Int32, ByRef BrickRes As Double) As Int32
    Declare Ansi Function St7GetBrickResultUCS Lib "St7API.DLL" (ByVal uID As Int32, ByVal ResultType As Int32, ByVal UCSId As Int32, ByVal BrickNum As Int32, ByVal ResultCase As Int32, ByVal SampleLocation As Int32, ByRef NumPoints As Int32, ByRef NumColumns As Int32, ByRef BrickRes As Double) As Int32
    Declare Ansi Function St7GetUserSpectralName Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetNodeKTranslation3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeKRotation3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeKDamping3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal UCSId As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetNodeNSMass2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal NodeNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamSupport2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamDLL4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamDML4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamDLG4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal BeamDir As Int32, ByVal ProjectFlag As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCFL4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCFG4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCML4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamCMG4 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamNSMass7ID Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByVal DLType As Int32, ByVal ID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPipePressure2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPipeTemperature2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBeamPreTension1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BeamNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlatePreStress3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateFaceSupport1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateEdgeSupport1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal EdgeNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateNSMass2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateConvection2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetPlateRadiation2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal PlateNum As Int32, ByVal CaseNum As Int32, ByVal EdgeNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickSupport1 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal Status As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickPreStress3 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetBrickNSMass2 Lib "St7API.DLL" (ByVal uID As Int32, ByVal BrickNum As Int32, ByVal FaceNum As Int32, ByVal CaseNum As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7EnableLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7DisableLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetLoadCaseStatus Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32, ByRef OnOff As Int32) As Int32
    Declare Ansi Function St7SetLinearBucklingInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetLinearBucklingInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetNaturalFrequencyInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNaturalFrequencyInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetNonlinearStaticInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNonlinearStaticInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetNonlinearTransientInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetNonlinearTransientInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetLinearTransientInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetLinearTransientInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetTransientHeatInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetTransientHeatInitialFile Lib "St7API.DLL" (ByVal uID As Int32, ByVal FileName As String, ByRef CaseNum As Int32, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7SetModalDampingType Lib "St7API.DLL" (ByVal uID As Int32, ByVal DampType As Int32) As Int32
    Declare Ansi Function St7GetModalDampingType Lib "St7API.DLL" (ByVal uID As Int32, ByRef DampType As Int32) As Int32
    Declare Ansi Function St7SetHarmonicRange Lib "St7API.DLL" (ByVal uID As Int32, ByVal NumSteps As Int32, ByVal F1 As Double, ByVal F2 As Double) As Int32
    Declare Ansi Function St7GetHarmonicRange Lib "St7API.DLL" (ByVal uID As Int32, ByRef NumSteps As Int32, ByRef F1 As Double, ByRef F2 As Double) As Int32
    Declare Ansi Function St7SetHeatLoadCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7GetHarmonicBaseVector Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetHarmonicBaseVector Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetHarmonicLoadType Lib "St7API.DLL" (ByVal uID As Int32, ByVal hType As Int32) As Int32
    Declare Ansi Function St7GetHarmonicLoadType Lib "St7API.DLL" (ByVal uID As Int32, ByRef hType As Int32) As Int32
    Declare Ansi Function St7SetLSAFreedomCase Lib "St7API.DLL" (ByVal uID As Int32, ByVal CaseNum As Int32) As Int32
    Declare Ansi Function St7SetSolverLogicalParameter Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByVal Value As Byte) As Int32
    Declare Ansi Function St7GetSolverLogicalParameter Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByRef Value As Byte) As Int32
    Declare Ansi Function St7SetSolverIntegerParameter Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByVal Value As Int32) As Int32
    Declare Ansi Function St7GetSolverIntegerParameter Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByRef Value As Int32) As Int32
    Declare Ansi Function St7SetSolverDoubleParameter Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByVal Value As Double) As Int32
    Declare Ansi Function St7GetSolverDoubleParameter Lib "St7API.DLL" (ByVal uID As Int32, ByVal Parameter As Int32, ByRef Value As Double) As Int32
    Declare Ansi Function St7GetAttribute Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal AttributeType As Int32, ByVal LocalID As Int32, ByVal CaseNum As Int32, ByRef AttributeDoubles As Double, ByRef AttributeLogicals As Byte, ByRef TypeId As Int32) As Int32
    Declare Ansi Function St7GetAttributeID Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal AttributeType As Int32, ByVal LocalID As Int32, ByVal CaseNum As Int32, ByVal ID As Int32, ByRef AttributeDoubles As Double, ByRef AttributeLogicals As Byte, ByRef TypeId As Int32) As Int32
    Declare Ansi Function St7GetElementGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByRef GroupID As Int32) As Int32
    Declare Ansi Function St7SetElementGroup Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal GroupID As Int32) As Int32
    Declare Ansi Function St7DeleteAttributeID Lib "St7API.DLL" (ByVal uID As Int32, ByVal Entity As Int32, ByVal EltNum As Int32, ByVal AttributeType As Int32, ByVal LocalID As Int32, ByVal CaseNum As Int32, ByVal ID As Int32) As Int32
    Declare Ansi Function St7NewTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableName As String, ByVal TableType As Int32, ByVal NumEntries As Int32, ByRef Doubles As Double, ByRef TableID As Int32) As Int32
    Declare Ansi Function St7DeleteTable Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32) As Int32
    Declare Ansi Function St7GetTableType Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByRef TableType As Int32) As Int32
    Declare Ansi Function St7GetTableName Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByVal TableName As String, ByVal MaxStringLen As Int32) As Int32
    Declare Ansi Function St7GetNumTableRows Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByRef NumRows As Int32) As Int32
    Declare Ansi Function St7GetTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByVal MaxRows As Int32, ByRef NumRows As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetTableData Lib "St7API.DLL" (ByVal uID As Int32, ByVal TableID As Int32, ByVal NumEntries As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7SetLinkData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByVal LinkType As Int32, ByRef LinkData As Int32) As Int32
    Declare Ansi Function St7GetLinkData Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef LinkType As Int32, ByRef LinkData As Int32) As Int32
    Declare Ansi Function St7SetLinkDoubles Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByVal LinkType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetLinkDoubles Lib "St7API.DLL" (ByVal uID As Int32, ByVal LinkNum As Int32, ByRef LinkType As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetBeamProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef BeamType As Int32, ByRef SectionType As Int32, ByRef MirrorType As Int32, ByRef SectionData As Double, ByRef BeamMaterial As Double) As Int32
    Declare Ansi Function St7GetPlateProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef SectionData As Double, ByRef PlateMaterial As Double) As Int32
    Declare Ansi Function St7GetBrickProperty Lib "St7API.DLL" (ByVal uID As Int32, ByVal PropNum As Int32, ByRef BrickMaterial As Double) As Int32
    Declare Ansi Function St7SetTransientInitialConditions Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32
    Declare Ansi Function St7GetTransientInitialConditions Lib "St7API.DLL" (ByVal uID As Int32, ByRef Doubles As Double) As Int32

End Module
