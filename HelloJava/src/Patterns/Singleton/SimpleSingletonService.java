package Patterns.Singleton;

import java.util.Objects;

public class SimpleSingletonService {
    private static SimpleSingletonService service;
    private String id;

    private SimpleSingletonService(String id){
        this.id = id;
    }

    public static SimpleSingletonService getInstance(){
        if(Objects.isNull(service)){
            service = new SimpleSingletonService(java.util.UUID.randomUUID().toString());
            System.out.println("    New instance of SimpleSingletonService was created");
        }
        System.out.println("    Giving you existing instance");
        return service;
    }

    public String getId() {
        return id;
    }
}