# Cadmus Epigraphy API

This API provides the development environment for Cadmus epigraphic components.

🐋 Quick Docker image build (you need to have a `buildx` container):

```bash
docker buildx create --use

docker buildx build . --platform linux/amd64,linux/arm64,windows/amd64,windows/arm64 -t vedph2020/cadmus-epigraphy-api:3.0.0 -t vedph2020/cadmus-epigraphy-api:latest --push
```

(replace with the current version).

## History

- 2025-06-03: updated packages.

### 7.0.0

- 2025-05-05:
  - ⚠️ updated packages with modified support model.

### 6.0.0

- 2025-04-01:
  - ⚠️ updated packages with new models (V7).
  - modified thesauri accordingly.

### 5.0.0

- 2025-03-27:
  - ⚠️ updated packages with new models (V6).
  - added thesauri.
- 2025-01-28: updated packages.
- 2025-01-23:
	- updated packages.
	- Dockerfile: added `--platform` for `docker buildx build`.
- 2025-01-01: updated packages.
- 2024-12-23: updated packages.
- 2024-12-03: updated packages.
- 2024-11-30: updated packages.
- 2024-11-22: updated API packages.
- 2024-11-20: updated packages.
- 2024-11-18: ⚠️ upgraded to .NET 9.
- 2024-10-30:
  - ⚠️ updated packages for breaking change in models for support and writing.
- 2024-09-16: updated packages.
- 2024-07-14: updated packages.
- 2024-06-22:
  - updated packages.
  - added to configuration epigraphic parts for support fragments and writing signs.
- 2024-06-09: updated packages.
- 2024-05-24: updated packages.
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
