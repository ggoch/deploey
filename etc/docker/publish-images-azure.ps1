param ($version='latest')

docker login further.azurecr.io --username further --password gp0kk3vnCyB7AY4hL9GJEEgP641X02vVpRZLpGB7SU+ACRDczw1N

docker tag mycompanyname/chengyiv2-db-migrator:$version further.azurecr.io/chengyiv2-db-migrator:$version

docker tag mycompanyname/chengyiv2-angular:$version further.azurecr.io/chengyiv2-angular:$version

docker tag mycompanyname/chengyiv2-api:$version further.azurecr.io/chengyiv2-api:$version

docker tag mycompanyname/chengyiv2-authserver:$version further.azurecr.io/chengyiv2-authserver:$version

docker push further.azurecr.io/chengyiv2-db-migrator:$version

docker push further.azurecr.io/chengyiv2-angular:$version

docker push further.azurecr.io/chengyiv2-api:$version

docker push further.azurecr.io/chengyiv2-authserver:$version