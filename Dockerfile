FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app
EXPOSE 80

COPY ["Jwt/Jwt.csproj", "Jwt/"]
RUN dotnet restore "Jwt/Jwt.csproj"

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final-env
WORKDIR /app
COPY --from=build-env /app/out .
RUN apt-get update && apt-get install -y curl
ENTRYPOINT [ "dotnent", "Jwt.dll" ]