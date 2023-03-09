FROM node:18.14.0 AS build-env
WORKDIR /app

COPY . ./

RUN npm install && npm run build

FROM nginx:1.21.3-alpine
COPY --from=build-env /app/dist /usr/share/nginx/html

#COPY .docker/nginx/prod.conf /temp/prod.conf
#RUN envsubst /app < /temp/prod.conf > /etc/nginx/conf.d/default.conf


EXPOSE 80
EXPOSE 8080



CMD ["nginx", "-g", "daemon off;"]
