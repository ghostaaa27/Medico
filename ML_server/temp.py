import numpy as np
import pandas as pd
from flask import Flask, jsonify, request
from flask_cors import CORS

app = Flask(__name__)
CORS(app)


@app.route('/predicted_disease', methods=['POST'])
def predicted_disease():
    
    data = request.form.getlist("arrData[]")
    for i in data:
        print(i)
    
    return "dangue"


#predicted_disease()


if __name__ == "__main__":
     print("starting python flask server")
     app.run(port=8000)