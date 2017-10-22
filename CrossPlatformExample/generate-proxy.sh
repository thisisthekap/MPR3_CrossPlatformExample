#!/bin/bash
rm swagger.json
wget http://localhost:5000/swagger/v1/swagger.json
rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi
rm -rf Generated/*
rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi
autorest -Input swagger.json \
    -CodeGenerator CSharp \
    -Namespace CrossPlatformExample.Proxy \
    -OutputDirectory ./Generated \
    -ClientName CrossPlatformExampleClient
rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi
rm swagger.json
