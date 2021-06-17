terraform apply -auto-approve
web_server_ip=$(az vm show --resource-group awray-project --name articulatevm -d --query [publicIps] -o tsv)
echo "host=ssh://azureuser@${web_server_ip}"
docker context create my-context --docker "host=ssh://azureuser@${web_server_ip}"
docker context use my-context
docker-compose pull  
docker compose up 