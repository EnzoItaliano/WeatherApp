
# Weather App

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)

I created this project to study C# using a service-oriented architecture (SOA). The biggest challenge was understanding the architecture and organizing the project inside the Visual Studio, but in the end, I could achieve the objective with 3 separate services.

## Table of contents

Aqui você coloca links para acessar mais facilmente cada um dos tópicos do seu README.

Exemplo:

- [Architecture](#architecture)
- [Features](#features)
- [Build instructions](#build-instructions)

## Architecture

Using SOA in this project brought the benefit of scalability, flexibility, and ease of maintenance. With self-contained services, each component's development, deployment, and maintenance is easier to do independently, leading to faster deployment and more agile responses to changes during the development. Additionally, SOA can provide better fault tolerance and reliability by isolating failures in individual services. Integrating other systems and services in the future is also easier when using this structure.

**C# and .NET**

The technologies used were C# and .NET with the objective of the study. With the support of object-oriented programming principles C# was able to help with the structure and reliability of the system. .NET which is a robust and powerful framework for building web APIs, is widely used in enterprise-level applications, making it a good choice to build a highly scalable and performant API.

**OpenWeather**

The OpenWeather API is a popular weather data provider that offers weather information for any location on Earth. It provides various weather data such as temperature, wind speed, humidity, pressure, cloudiness, precipitation, and more. It is necessary a key use the API and offers good services even in the free version for a simple and small project.

## Features

Three endpoints are available on my API with some improvements on the results given by OpenWeather.

```bash
CityLocation/city/{city_name}
```

This endpoint retrieves 5 cities with their name, latitude, longitude, and country.

```bash
WeatherCurrent/weather/{lat},{lon}
```

This endpoint retrieves information about the current weather of a location.

```bash
WeatherForecast/forecast/{lat},{lon}
```

This endpoint retrieves a forecast of the weather for the next 5 days.

## Build instructions

To build the project simply enter each project folder and run.

```bash
dotnet build
```

To execute the project got to the bin/Release/net6.0 and execute the .dll file.

```bash
dotnet run "WeatherCurrent.dll"
```
