FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# restore the robots project
COPY Robots/*.csproj ./Robots/
RUN cd Robots && dotnet restore

# copy everything else and build app
COPY Robots/. ./Robots/
WORKDIR /app/Robots
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/Robots/out ./
ENTRYPOINT ["dotnet", "Robots.dll"]
