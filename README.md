🐱 Cat UI – Prueba Técnica Xpertgroup

Este proyecto es una aplicación frontend desarrollada en Angular que permite visualizar razas de gatos consumiendo TheCatAPI.
El usuario puede seleccionar una raza, ver su información relevante y navegar por un carrusel de imágenes asociado a la raza seleccionada.

🚀 Tecnologías utilizadas

Angular (Standalone Components)
TypeScript
RxJS
TheCatAPI
HTML / CSS

🧱 Arquitectura

El proyecto sigue una arquitectura clara y escalable:
src/
 ├── app/
 │   ├── core/
 │   │   └── services/
 │   │       └── cat.service.ts
 │   ├── features/
 │   │   └── cats/
 │   │       ├── cats.component.ts
 │   │       ├── cats.component.html
 │   │       └── cats.component.css

Principios aplicados
Separación de responsabilidades
Consumo de APIs desde servicios
Componentes standalone (Angular moderno)
Lógica de negocio fuera del template

📡 Consumo de API
La aplicación consume los siguientes endpoints de TheCatAPI:

Listado de razas
GET https://api.thecatapi.com/v1/breeds

Imágenes por raza
GET https://api.thecatapi.com/v1/images/search?breed_ids={id}&limit=5

El consumo se realiza desde un servicio centralizado (CatsService) utilizando HttpClient.

🎯 Funcionalidades
Carga dinámica de razas de gatos
Selección de una raza desde un combo desplegable

Visualización de:
Nombre de la raza

Descripción

Carrusel de imágenes

Navegación manual del carrusel (anterior / siguiente)

▶️ Ejecución del proyecto
1️⃣ Ejecutar en modo desarrollo
## Frontend
cd front
npm install
ng serve

## Backend
cd back
npm install
npm run start

3️⃣ Abrir en el navegador
http://localhost:4200

🧠 Decisiones técnicas
Se utilizó standalone components para reducir la dependencia de módulos y simplificar la estructura.

El estado del carrusel se maneja en el componente, manteniendo el HTML limpio.

Se evitó el uso de librerías externas para el carrusel con el fin de mostrar lógica propia y control del estado.

👤 Autor
Humberto Rafael Ariza Villanueva
Desarrollador de software
