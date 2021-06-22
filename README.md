# Articulate

## 1. Introduction

This project is based on articulate the fast talking word game. In the game users are split into teams of 2 or more. A single member of the team is given a randomly generated word from one of six categories: Person, Nature, Object, Action, World or Random. This person has to describe the word given to them without saying the actually word to the rest of his team. The other members of  the team must guess the chosen word.

## 2. Architecture 
The project contains 4 services: frontend, articulate, categories and number. The fronted service is responsible for generating serving the webpage for users to interact with. The numbers service generates a random number from 1 to 100. The categories service selects one of the six categories mentioned in section 1 at random. Finally, the articulate service takes the output from the numbers and categories services' to produce a word for the user to articulate.

Each service inside of this project has been containerised for deployment. Containerisation of theses services made networking simplistic, as each container was connected to the same docker network where the name of the container is the hostname for the container on docker network. 

The directory `./config/` contains to environment variable files for develepment and production environments (`.dev.env` and `.prod.env`). These files can be used with the following command:   

```
$ docker compose --env-file <name> up 
```

During the creation of the project this was a useful feature which enabled me to easily switch between deploying locally and to an azure VM.

## 3. Deployment

All 4 containers (services) were deployed to an azure VM, where the frontend could be accessed by a public ip address or the dns name set in the terraform. 

### 3.1. Terraform 

All of the terraform inside of this project can be found in the `./terraform` directory. The terraform creates a virtual machine, virtaul network, storage account, network interface card, public ip address, network security group and a resource group on the Azure cloud platform.

### 3.2. Ansible 

All of the ansible for this project can be found in the `./ansible` directory. The playbook and inventory are run on the GitHub Actions Runner to configure the deployment virrtua. machine