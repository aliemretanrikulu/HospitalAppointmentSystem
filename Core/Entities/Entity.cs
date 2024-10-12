﻿

namespace Core.Entities;

public abstract class Entity<TId>

{
    public TId Id { get; set; }

    public string Name { get; set; }
}