import numpy as np 
import pickle
import pandas as pd
from flask import Flask, request, jsonify
import traceback

app = Flask(__name__)
model = pickle.load(open('model1.pkl', 'rb'))

@app.route('/pred', methods = ['POST'])
def pred():
    if model:
        try:
            pre = request.get_json(force=True)
            print(pre)
            query = pd.DataFrame(pre, index =[0])
            prediction = model.predict(query)
            output = (round(prediction[0], 2)) * 100

            return jsonify({'Your admittance chance is' : output})
        except:
             return jsonify({'trace': traceback.format_exc()})
    else:
        print ('Train the model first')
        return ('No model here to use')
if __name__ == "__main__":
  app.run(debug = True)