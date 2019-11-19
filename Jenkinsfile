pipeline {
  agent {
    label 'Automation'
  }
  stages {
    
    stage('build') {
      steps {
        echo 'Start build'
        powershell '''
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
          dir
          dotnet xunit -c development -html report.html -verbose
        '''
        echo 'End test'
      }
    }
    
    environment {
      Test_Environment = 'development'
    }
  }
}
