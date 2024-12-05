from flask import Flask, request, jsonify
import requests
from datetime import datetime, timezone

app = Flask(__name__)

OPENWEATHER_API_KEY = '1085356b674bdaa8cc435af72ab1f110'

def get_weather(city_name):
    weather_url = f"http://api.openweathermap.org/data/2.5/forecast?q={city_name}&appid={OPENWEATHER_API_KEY}&units=metric"
    response = requests.get(weather_url)

    if response.status_code == 200:
        data = response.json()
        forecasts = []
        
        for entry in data['list']:
            timestamp = entry['dt']
            date = datetime.fromtimestamp(timestamp, timezone.utc).strftime('%Y-%m-%d')
            time = datetime.fromtimestamp(timestamp, timezone.utc).strftime('%H:%M:%S')
            temp = entry['main']['temp']
            humidity = entry['main']['humidity']
            pressure = entry['main']['pressure']
            weather_main = entry['weather'][0]['main']
            weather_description = entry['weather'][0]['description']

            forecast = {
                'date': date,
                'time': time,
                'temperature': temp,
                'humidity': humidity,
                'pressure': pressure,
                'main': weather_main,
                'description': weather_description
            }
            forecasts.append(forecast)
        
        return {
            "city": city_name,
            "forecast": forecasts
        }
    else:
        return {"error": "Unable to fetch weather data"}

@app.route('/weather', methods=['GET'])
def weather():
    city = request.args.get('city')
    if not city:
        return jsonify({'error': 'City parameter is required'}), 400
    try:
        weather_data = get_weather(city)
        return jsonify(weather_data), 200
    except Exception as e:
        return jsonify({'error': str(e)}), 500

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
