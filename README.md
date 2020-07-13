# Proyecto de ejemplo de uso de SeriLog con enrichers y Seq como Log Management.

SeriLog se configura en Program.cs a partir del nodo Serilog presente en appsettings.json en lugar de usar _configuration as code_.

Se utiliza los Sinks de Consola, Archivo Plano, Archivo Json y Seq.

Para levantar una instancia de Seq con Docker:

```
docker run --name seq -d -p 5341:80 -e ACCEPT_EULA=Y datalust/seq 

# (Opcional) Para especificar salida de datos al equipo local con un volumen

-v /tmp/seq:/data
```

Referencia: [https://www.codewithmukesh.com/blog/serilog-in-aspnet-core-3-1/](https://www.codewithmukesh.com/blog/serilog-in-aspnet-core-3-1/)
