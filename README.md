# Clean Architecture / Ports & Adapters?

- Translate domain/internal message to outside / dto => adapter
- send and receive data from outside, translate to internal / domain => adapter
- decide which processor, based on domain + message => outside (infra?)