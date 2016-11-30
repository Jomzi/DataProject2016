import os
from flask import Flask, request, session, g, redirect, url_for, abort, render_template, flash
from flask.ext.mysql import MySQL
app = Flask(__name__)

mysql = MySQL()
 
# MySQL configurations
app.config['MYSQL_DATABASE_USER'] = 'root'
app.config['MYSQL_DATABASE_PASSWORD'] = 'krock47'
app.config['MYSQL_DATABASE_DB'] = 'zoo'
app.config['MYSQL_DATABASE_HOST'] = 'localhost'
mysql.init_app(app)

# Connect to the database
conn = mysql.connect()
cursor = conn.cursor()

# Query the Animals table
cursor.execute("SELECT * FROM ANIMALS")
animals = cursor.fetchall()
conn.close()

# View function mapped to the root url of the site
@app.route('/')
def hello_world():
  return render_template('index.html', animals = animals)
