#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p aec3193e-fb11-4bb0-bc62-96894faf91eb -t
    fi
    cd ../
fi

docker-compose up -d
