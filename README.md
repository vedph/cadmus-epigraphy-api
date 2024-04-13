# Cadmus Epigraphy API

This API provides the development environment for Cadmus epigraphic components.

🐋 Quick Docker image build:

    docker build . -t vedph2020/cadmus-epigraphy-api:3.0.0 -t vedph2020/cadmus-epigraphy-api:latest

(replace with the current version).

## History

- 2024-04-13: updated packages.
- 2023-11-21: updated packages.

### 4.0.0

- 2023-11-18: ⚠️ Upgraded to .NET 8.
- 2023-11-07: updated packages.

### 3.0.0

- 2023-06-17: moved to PostgreSQL.
- 2023-06-02: updated packages.

### 2.0.0

- 2023-05-24: updated packages (breaking change in general parts introducing [AssertedCompositeId](https://github.com/vedph/cadmus-bricks-shell/blob/master/projects/myrmidon/cadmus-refs-asserted-ids/README.md#asserted-composite-id)).
- 2023-05-16: updated packages.
- 2023-04-12: updated packages.

### 1.0.1

- 2023-03-09: updated packages.
- 2023-02-11: updated thesauri.

### 1.0.0

- 2023-02-03: migrated to new components factory. This is a breaking change for backend components, please see [this page](https://myrmex.github.io/overview/cadmus/dev/history/#2023-02-01---backend-infrastructure-upgrade). Anyway, in the end you just have to update your libraries and a single namespace reference. Benefits include:
  - more streamlined component instantiation.
  - more functionality in components factory, including DI.
  - dropped third party dependencies.
  - adopted standard MS technologies for DI.

### 0.0.1

- 2023-01-04: initial release.
