# DataProject2016
    Zoo Project 2016
Data Representation and Querying
                                                                                      by 
                                                                         James O’Hanlon  
                                                                            G00318662          
                                                                               
I designed my Application for Dublin zoo. It allows web uses or zoo visitors to search for different types of animals in the zoo and displays information about them. The animal database can also be edits, added or deleted by the staff at the zoo.

They following document contains the steps I took to create my single-page application for data representation and querying.

GitHub

Created a new repository: DataProject2016

MySql

Downloaded and installed MySql version workbench 6.3 CE
Created a sample database named ‘zoo’. Created a Table, ’Animals’ and populated 
the table with sample data. See Database.sql

Python

Downloaded and installed python. Used script get-pip.py to install ‘pip’ and 
‘setuptools’ and used pip to install ‘virtualenv’.

Virtualenv: Used virtualenv to create a virtual environment ‘venv’. Activated 
Venv in a command prompt using: venv\scripts\activate


Flask

Flask install: Used pip to install Flask: pip install flask 
Flask: app: Created view and templatefiles for flask: Hello.py and
Templates\index.html.
The view (Hello.py) uses flask.ext.mysql to create a connection to the 
Database. It then runs a database query to return all the records in the Animals table
And stores the results in a variable.
The root url of the web app is mapped to a function hello world, using the flask
@app.route decorator. When the user opens the web app, this function is called.
It calls render template and passes the results of the database query to the template,
Index.html loops through the results of the database query and outputs them to a table.

Css: Added a simple style sheet to improve the style of the style  of the page:
Static\style.css

Testing: Used builtin development web server to test. Before starting it, the environment
Variable FLASK_APP needs to be set to the view file: set
FLASK_APP=Hello.py 

The command: python –m flask run, will start builtin web server
at 127.0.0.1:5000

Open a browser at this url to see the application running.

Finally I uploaded it to github.

………..


The following instructions are for a new user to get the app up and running…

Install MySql:  Downloaded and installed MySql version workbench 6.3 CE
Created a sample database: Create a new Database named ‘zoo’. 
Use the script Database.sql to create the ‘Animals’ table and populate it with
Sample data.

Create a ‘myproject’ folder and get the flask project files from 
Github: https://github.com/Jomzi/DataProject2016
\Hello.py
\templates\index.html
\static\style.css

Update the database login details in Hello.py to correspond to your MySql server’s login.
(Search for the section under ‘MySql Configurations’) 

Download and install Python and Flask, pip, setuptools, virtualenv.
See: http://flask.pocoo.org/docs/0.11/installation/#installation
Start flask's builtin server:
First you need to tell your terminal the application to work with by exporting the FLASK_APP environment variable: set FLASK_APP=Hello.py
Then: python -m flask run
You should see: Running on http://127.0.0.1:5000/
Open a browser at http://127.0.0.1:5000/







