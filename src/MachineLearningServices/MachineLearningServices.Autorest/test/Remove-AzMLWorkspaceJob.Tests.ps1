if(($null -eq $TestName) -or ($TestName -contains 'Remove-AzMLWorkspaceJob'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzMLWorkspaceJob.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-AzMLWorkspaceJob' {
    It 'DeleteJob' -skip {
        {
            Remove-AzMLWorkspaceJob -ResourceGroupName $env.TestGroupName -WorkspaceName $env.mainWorkspace -Name $env.commandJob01
            Remove-AzMLWorkspaceJob -ResourceGroupName $env.DataGroupName -WorkspaceName $env.computeWorkspace -Name $env.commandJob02
        } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
