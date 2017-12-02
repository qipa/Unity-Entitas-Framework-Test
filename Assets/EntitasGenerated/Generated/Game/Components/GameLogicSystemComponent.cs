//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity logicSystemEntity { get { return GetGroup(GameMatcher.LogicSystem).GetSingleEntity(); } }
    public LogicSystemComponent logicSystem { get { return logicSystemEntity.logicSystem; } }
    public bool hasLogicSystem { get { return logicSystemEntity != null; } }

    public GameEntity SetLogicSystem(Entitas.Systems newSystems) {
        if (hasLogicSystem) {
            throw new Entitas.EntitasException("Could not set LogicSystem!\n" + this + " already has an entity with LogicSystemComponent!",
                "You should check if the context already has a logicSystemEntity before setting it or use context.ReplaceLogicSystem().");
        }
        var entity = CreateEntity();
        entity.AddLogicSystem(newSystems);
        return entity;
    }

    public void ReplaceLogicSystem(Entitas.Systems newSystems) {
        var entity = logicSystemEntity;
        if (entity == null) {
            entity = SetLogicSystem(newSystems);
        } else {
            entity.ReplaceLogicSystem(newSystems);
        }
    }

    public void RemoveLogicSystem() {
        logicSystemEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public LogicSystemComponent logicSystem { get { return (LogicSystemComponent)GetComponent(GameComponentsLookup.LogicSystem); } }
    public bool hasLogicSystem { get { return HasComponent(GameComponentsLookup.LogicSystem); } }

    public void AddLogicSystem(Entitas.Systems newSystems) {
        var index = GameComponentsLookup.LogicSystem;
        var component = CreateComponent<LogicSystemComponent>(index);
        component.systems = newSystems;
        AddComponent(index, component);
    }

    public void ReplaceLogicSystem(Entitas.Systems newSystems) {
        var index = GameComponentsLookup.LogicSystem;
        var component = CreateComponent<LogicSystemComponent>(index);
        component.systems = newSystems;
        ReplaceComponent(index, component);
    }

    public void RemoveLogicSystem() {
        RemoveComponent(GameComponentsLookup.LogicSystem);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherLogicSystem;

    public static Entitas.IMatcher<GameEntity> LogicSystem {
        get {
            if (_matcherLogicSystem == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LogicSystem);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLogicSystem = matcher;
            }

            return _matcherLogicSystem;
        }
    }
}
