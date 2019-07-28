resource "azurerm_resource_group" "appservice" {
    name     = "${var.resource_group_name}"
    location = "${var.location}"
}

resource "azurerm_app_service_plan" "appservice" {
  name                = "rushtodo-appserviceplan"
  location            = "${azurerm_resource_group.appservice.location}"
  resource_group_name = "${azurerm_resource_group.appservice.name}"

  sku {
    tier = "Standard"
    size = "S1"
  }
}

resource "azurerm_app_service" "appservice" {
  name                = "rushtodo-appservice"
  location            = "${azurerm_resource_group.appservice.location}"
  resource_group_name = "${azurerm_resource_group.appservice.name}"
  app_service_plan_id = "${azurerm_app_service_plan.appservice.id}"

  site_config {
    "always_on" = "true"
  }

  app_settings = {
    "ASPNETCORE_ENVIRONMENT" = "Production"
  }
}