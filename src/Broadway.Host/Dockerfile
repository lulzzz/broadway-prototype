FROM docker-hub.2gis.ru/microsoft/dotnet:2.0.6-runtime-deps
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["./Broadway.Host"]

COPY . .