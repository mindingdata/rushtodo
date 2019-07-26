variable "client_id" {}
variable "client_secret" {}


variable "database_user" {}
variable "database_password" {}

variable "agent_count" {
    default = 1
}

variable "ssh_public_key" {
    default = "~/.ssh/id_rsa.pub"
}

variable "dns_prefix" {
    default = "rushtodo-k8s"
}

variable cluster_name {
    default = "rushtodo-k8s"
}

variable resource_group_name {
    default = "azure-rushtodo"
}

variable location {
    default = "Central US"
}

variable log_analytics_workspace_name {
    default = "rushTodoLogAnalyticsWorkspaceName"
}

# refer https://azure.microsoft.com/global-infrastructure/services/?products=monitor for log analytics available regions
variable log_analytics_workspace_location {
    default = "eastus"
}

# refer https://azure.microsoft.com/pricing/details/monitor/ for log analytics pricing 
variable log_analytics_workspace_sku {
    default = "PerGB2018"
}