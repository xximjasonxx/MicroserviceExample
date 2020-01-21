FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as sdk
WORKDIR /code
COPY . .
RUN dotnet publish -c Release -o output

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 as runtime
WORKDIR /app
COPY --from=sdk /code/output .

EXPOSE 80
ENTRYPOINT [ "dotnet", "names-api.dll" ]