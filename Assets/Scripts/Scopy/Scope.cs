﻿using System;
using System.Collections.Generic;

public class Scope
{
    private readonly Dictionary<Type, object> _services = new();

    public void Add(Type type, object service) 
    {
        _services.Add(type, service);
    }
    
    public void Add<T>(T service) 
    {
        _services.Add(typeof(T), service);
    }
    
    public bool Remove(object obj) 
    {
        return _services.Remove(obj.GetType());
    }

    public bool Remove(Type type) 
    {
        return _services.Remove(type);
    }
    
    public void Remove<T>() 
    {
        _services.Remove(typeof(T));
    }

    public object Get(Type serviceType) 
    {
        _services.TryGetValue(serviceType, out var service);
        return service;
    }

    public T Get<T>()
    {
        _services.TryGetValue(typeof(T), out var service);
        return (T)service;
    }
}