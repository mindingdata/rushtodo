resource "azurerm_resource_group" "keyvault" {
    name     = "${var.resource_group_name}"
    location = "${var.location}"
}

resource "azurerm_key_vault" "keyvault" {
  name                        = "rushtodo-keyvault"
  location                    = "${azurerm_resource_group.keyvault.location}"
  resource_group_name         = "${azurerm_resource_group.keyvault.name}"
  enabled_for_disk_encryption = true
  tenant_id                   = "fabc21bd-11c2-4b90-9802-45eb8145cae2"

  sku_name = "standard"

  tags = {
    environment = "Development"
  }
}