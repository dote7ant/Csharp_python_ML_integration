# C# integration of python machine learning models.

This repository contains the results and technical aspects of making api calls to an ML model built and hosted in python from Flask and displaying the results in a WPF. 
## 1. Python Model.
## Simple Linear ML model to predict the admittance chance to university based on GRE and TOEFL scores.
A model to predict the chance of being admitted to university based on GRE and TOEFL scores. The model is a linear regression model. It is a simple model to test the use case of 
using the model as an api to a C# environment


### 2. C# WPF
Create a basic interface to enter and display results of the model.


## Getting Started.

To get a copy of this solution fork the repository. On the upper right there is a Fork button click on it, then after this is successfull click on git clone or download to get a local copy on you machine. 

## Overview.

This repository contains the technical aspects of integrationg python ML models in C# as outlined above. The project applies various techniques and other coding techniques both in C# and python to get the desired effect. 

## Files in the Repository.

The repository contains the following files/folders:

    *license: MIT
    *C# files
    *Python files
    *README: This README.

## Packages

The following packages are necessary to run the Python code:

    Flask
    pickle
    pandas
    jsonify
    request
    traceback
    sklearn
    numpy
  
  The following packages are necessary to run the C# code:
  
     System : Xml, Threading.Tasks, Text, linq, Drawing, Data, ComponentModel, Collections.Generic 
     unitrest_net.http
     Newtonsoft.Json
     
    

### Prerequisites
1. Visual studio(**For my case am using 2019**).
2. Python 3.6 and above
3. Flask 


### Installing

Kindly clone the repo to gain all the associated code

### Usage 
     cd into python folder code
     activate python virtual environment
     start up the flask server
     
     start up visual studio
     build
     start debugging
     interact with interface
     
## Built With

* [Python 3.8.6]- Python
* [Visual Studio Community 2019 16.10.3] - visual studio

#### Thoughts
While the solution works through the use of unitrest_net the library has not been actively monitored and updated by its developers a better solution will need to be identified in future. For now this works.



## Authors

* **Antony Mwaura Ngige** - *Initial work* 


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to my mentors, code forums and peers
* Inspiration
