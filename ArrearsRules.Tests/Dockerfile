FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN

WORKDIR /app

# Copy csproj and nuget config and restore as distinct layers
COPY ./ArrearsRules.sln ./
COPY ./ArrearsRules/ArrearsRules.csproj ./ArrearsRules/
COPY ./ArrearsRules.Tests/ArrearsRules.Tests.csproj ./ArrearsRules.Tests/
COPY /NuGet.Config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./ArrearsRules/ArrearsRules.csproj
RUN dotnet restore ./ArrearsRules.Tests/ArrearsRules.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out ArrearsRules.Tests/ArrearsRules.Tests.csproj

CMD dotnet test
