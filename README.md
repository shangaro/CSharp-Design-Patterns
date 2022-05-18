# C#-Design-Patterns and Principles

## Patterns

 1. Factory Design Pattern
 2. Abstract Design Pattern

 ## Principles
 1. OpenClosePrinciple - A method should be closed for changes and open for extensions.

az login --service-principal -u $(system.username) --password $(system.password) --tenant $(system.tenant)
az account set -s $(subscription)

az batch application package delete --application-name $(app) -n $(batch) -g $(rg) --version-name "1.0" --yes

az batch application package create --application-name $(app) -n $(batch) --package-file $(System.ArtifactsDirectory)\_Processor-Dev\drop\Notification.Processor.zip -g $(rg) --version-name "1.0"

az batch account login --resource-group $(rg) --name $(batch)
