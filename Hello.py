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
conn = mysql.connect()
cursor = conn.cursor()
cursor.execute("SELECT * FROM ANIMALS")
animals = cursor.fetchall()
conn.close()

@app.route('/')
def hello_world():
  return render_template('index.html', animals = animals)
