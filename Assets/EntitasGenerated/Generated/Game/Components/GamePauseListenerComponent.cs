//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PauseListenerComponent pauseListener { get { return (PauseListenerComponent)GetComponent(GameComponentsLookup.PauseListener); } }
    public bool hasPauseListener { get { return HasComponent(GameComponentsLookup.PauseListener); } }

    public void AddPauseListener(IPauseListener newValue) {
        var index = GameComponentsLookup.PauseListener;
        var component = CreateComponent<PauseListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePauseListener(IPauseListener newValue) {
        var index = GameComponentsLookup.PauseListener;
        var component = CreateComponent<PauseListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePauseListener() {
        RemoveComponent(GameComponentsLookup.PauseListener);
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

    static Entitas.IMatcher<GameEntity> _matcherPauseListener;

    public static Entitas.IMatcher<GameEntity> PauseListener {
        get {
            if (_matcherPauseListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PauseListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPauseListener = matcher;
            }

            return _matcherPauseListener;
        }
    }
}
