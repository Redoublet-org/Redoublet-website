FROM node:18.14.0 AS build-env
WORKDIR /app

COPY . ./

RUN npm install
#RUN npm run dev
ENTRYPOINT [ "npm", "run", "dev" ]

FROM nginx:1.21.3-alpine
COPY --from=build-env /app/dist /usr/share/nginx/html

EXPOSE 80

