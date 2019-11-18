pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        echo 'Start build'
        powershell(script: "dotnet build", returnStatus: true)
        echo 'End build'
      }
    }
    stage('test') {
      steps {
        echo 'Start test'
        powershell "dotnet xunit -c $env:Test_Environment -html report.html -verbose"
        echo 'End test'
      }
    }
  }
  environment {
    Test_Environment = 'development'
  }
}