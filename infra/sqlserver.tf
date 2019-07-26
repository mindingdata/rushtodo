resource "azurerm_resource_group" "sql" {
    name     = "${var.resource_group_name}"
    location = "${var.location}"
}

resource "azurerm_sql_server" "sql" {
  name                         = "rushtodo-sqlserver"
  resource_group_name          = "${azurerm_resource_group.sql.name}"
  location                     = "${azurerm_resource_group.sql.location}"
  version                      = "12.0"
  administrator_login          = "${var.database_user}"
  administrator_login_password = "${var.database_password}"

  tags = {
    environment = "Development"
  }
}

resource "azurerm_sql_database" "sql" {
  name                = "TodoApplication"
  resource_group_name = "${azurerm_resource_group.sql.name}"
  location            = "${azurerm_resource_group.sql.location}"
  server_name         = "${azurerm_sql_server.sql.name}"

  tags = {
    environment = "Development"
  }
}