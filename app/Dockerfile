FROM node:14.7.0-alpine AS build-angular-app
WORKDIR /usr/src/app
COPY package.json package-lock.json ./
RUN npm install
COPY . .
RUN npm run build

FROM nginx:1.21.0-alpine
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=build-angular-app /usr/src/app/dist/app /usr/share/nginx/html