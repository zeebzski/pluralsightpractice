FROM microsoft/dotnet:2.1-sdk 

COPY Grades.Core/ /app/src

COPY Grades.Core/Grades.Core.csproj /app/src

RUN dotnet restore /app/src/Grades.Core.csproj

COPY . /app

WORKDIR /app/src/
RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "out/Grades.Core.dll"]