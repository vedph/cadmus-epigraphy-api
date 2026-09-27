# Cadmus Epigraphy API

This API provides the development environment for Cadmus epigraphic components.

🐋 Quick Docker image build (you need to have a `buildx` container):

```bash
docker buildx create --use

docker buildx build . --platform linux/amd64,linux/arm64,windows/amd64,windows/arm64 -t vedph2020/cadmus-epigraphy-api:3.0.0 -t vedph2020/cadmus-epigraphy-api:latest --push
```

(replace with the current version).
