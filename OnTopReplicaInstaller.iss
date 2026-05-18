#define SourcePath "src\OnTopReplica\bin\Release"
#define AppVersion "4.8.4"
#define AppPublisher "giahoki"

[Setup]
WizardStyle=modern
WizardImageStretch=yes
AppId={{8F3B4C2A-1D5E-4F7A-9B3C-6E8D0A2F4C1B}}
AppName=OnTopReplica
AppVersion={#AppVersion}
AppVerName=OnTopReplica {#AppVersion}
AppPublisher={#AppPublisher}
DefaultDirName={commonpf}\OnTopReplica
DefaultGroupName=OnTopReplica
AllowNoIcons=yes
OutputDir=.
OutputBaseFilename=OnTopReplica_Installer
Compression=lzma
SolidCompression=yes
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
PrivilegesRequired=admin
UsedUserAreasWarning=no
UninstallDisplayIcon={app}\OnTopReplica.exe

[Files]
Source:"{#SourcePath}\*"; DestDir:"{app}"; Flags:ignoreversion recursesubdirs createallsubdirs; Excludes:"*.pdb"

[Icons]
Name:"{group}\OnTopReplica"; Filename:"{app}\OnTopReplica.exe"; WorkingDir:"{app}"
Name:"{autodesktop}\OnTopReplica"; Filename:"{app}\OnTopReplica.exe"; WorkingDir:"{app}"; Tasks:desktopicon

[Tasks]
Name:desktopicon; Description:"{cm:CreateDesktopIcon}"; GroupDescription:"{cm:AdditionalIcons}"

[Run]
Filename:"{app}\OnTopReplica.exe"; Description:"{cm:LaunchProgram,OnTopReplica}"; Flags:nowait postinstall skipifsilent

[UninstallDelete]
Type: filesandordirs; Name: "{localappdata}\OnTopReplica"
Type: filesandordirs; Name: "{userappdata}\OnTopReplica"
