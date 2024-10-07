# Sistema de Logs en C# con Azure Cosmos DB

## Descripción del Proyecto

Este proyecto es una aplicación API desarrollada en C# que registra logs (información de eventos, errores, etc.) y los almacena en Azure Cosmos DB. La aplicación es consumida desde un microservicio de colas creado en un reto anterior.

## Objetivos

- Crear una API que permita la gestión de logs.
- Almacenar logs en una base de datos de Azure Cosmos DB.
- Implementar una arquitectura hexagonal.
- Contener la API en una imagen de Docker y desplegarla en Azure Container Instances.

## Requisitos

- .NET 6.0 o superior
- Azure Cosmos DB
- Docker
- Azure Container Instances

## Modelo de Datos

La aplicación utiliza un modelo de datos simple para los logs, que incluye los siguientes campos:

- **ID**: Identificador único del log.
- **Type**: Tipo de log (Information, Warning, Error).
- **Description**: Descripción del log.
- **CreatedDate**: Momento en que se registra el log.

## Endpoints de la API

La API incluye los siguientes endpoints:

- **POST /logs**: Crear un nuevo log.
- **GET /logs**: Obtener una lista de todos los logs.
- **GET /logs/{id}**: Obtener un log específico por ID.
- **GET /logs/filter**: Filtrar logs por tipo o fecha.

## Arquitectura

La aplicación está diseñada siguiendo la arquitectura hexagonal, separando las preocupaciones de la lógica de negocio, la persistencia y la presentación.

## Docker

La aplicación está contenida en una imagen de Docker, lo que permite una fácil implementación y escalabilidad.

### Construir la Imagen de Docker

Para construir la imagen de Docker, ejecuta el siguiente comando en la raíz del proyecto:

```bash
docker build -t nombre-de-tu-imagen .
