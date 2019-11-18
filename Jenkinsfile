pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        echo 'Start build: $env:Test_Environment'
        powershell(script: 'dotnet build -c $env:Test_Environment', returnStatus: true)
        echo 'End build: $env:Test_Environment'
      }
    }
    stage('test') {
      steps {
        echo 'Start test: $env:Test_Environment'
        powershell 'dotnet xunit -c $env:Test_Environment -html report.html -verbose'
        echo 'End test: $env:Test_Environment'
      }
    }
  }
  environment {
    Test_Environment = 'development'
  }
}