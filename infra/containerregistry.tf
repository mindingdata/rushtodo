resource "azurerm_resource_group" "acr" {
    name     = "${var.resource_group_name}"
    location = "${var.location}"
}

resource "azurerm_container_registry" "acr" {
  name                     = "rushtodo-containerregistry"
  resource_group_name      = "${azurerm_resource_group.rg.name}"
  location                 = "${azurerm_resource_group.rg.location}"
  sku                      = "Premium"
  admin_enabled            = false
}