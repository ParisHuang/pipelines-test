pipeline {
  agent {
    node {
      label 'Automation'
    }

  }
  stages {
    stage('build') {
      steps {
        echo 'Start build'
        powershell '''
          cd ./src/pipelinestest
          dir
          dotnet build -c development
        '''
        echo 'End build'
      }
    }
    stage('test') {
      steps {
        echo 'Start test'
        powershell '''
          cd ./src/pipelinestest
          dir
          dotnet xunit -c development -html report.html -verbose
        '''
        echo 'End test'
      }
    }
  }
}