pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        echo 'Start build'
        powershell(script: 'dotnet build -c $env:Test_Environment', returnStatus: true)
        echo 'End build'
      }
    }
    stage('test') {
      steps {
        echo 'Start test'
        powershell(script: "dotnet xunit -c $env:Test_Environment -html report.html -verbose", returnStatus: true)
        echo 'End test'
      }
    }
  }
  environment {
    Test_Environment = 'development'
  }
}