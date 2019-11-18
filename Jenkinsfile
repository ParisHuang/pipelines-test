pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        powershell 'dotnet build -c $env:Test_Environment'
      }
    }
    stage('test') {
      steps {
        powershell 'dotnet xunit -c $env:Test_Environment -html report.html -verbose'
      }
    }
  }
  environment {
    Test_Environment = 'development'
  }
}