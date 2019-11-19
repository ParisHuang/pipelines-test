pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        echo 'Start build'
        powershell '''
          cd .\\src\\pipelinestest
          dir
          dotnet build -c development
        '''
        echo 'End build'
      }
    }
    stage('test') {
      steps {
        echo 'Start test'
        powershell(script: 'dotnet xunit -c development -html report.html -verbose', returnStatus: true)
        echo 'End test'
      }
    }
  }
  environment {
    Test_Environment = 'development'
  }
}