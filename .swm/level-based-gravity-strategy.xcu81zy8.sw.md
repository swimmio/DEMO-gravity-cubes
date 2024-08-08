---
title: Level Based Gravity Strategy
---
Level based gravity strategy is a mechanism that adjusts the gravity in the game based on the current level.

The gravity starts with a base value and increases as the level increases.

The base gravity is defined as a constant value, and the increase per level is also a constant.

The current gravity is calculated by multiplying the base gravity with the current level.

The level can be set, increased, or reset using specific methods.

This strategy allows for a dynamic and progressively challenging gameplay experience.

<SwmSnippet path="/unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" line="10">

---

## Base Gravity and Gravity Increase

The base gravity is defined as a constant <SwmToken path="unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" pos="10:7:7" line-data="        private readonly float _gravityBase = 9.8f;">`_gravityBase`</SwmToken> and the increase per level is defined as <SwmToken path="unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" pos="12:7:7" line-data="        private const float GravityIncreasePerLevel = 0.75f;">`GravityIncreasePerLevel`</SwmToken>.

```c#
        private readonly float _gravityBase = 9.8f;
        private int _level = 1;
        private const float GravityIncreasePerLevel = 0.75f;
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" line="14">

---

## Current Gravity Calculation

The current gravity is calculated by multiplying the base gravity with the current level.

```c#
        public float CurrentGravity => _gravityBase * _level;
        public float Gravity => _gravityBase * _level;
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" line="17">

---

## Setting the Level

The level can be set using the <SwmToken path="unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" pos="21:5:5" line-data="        public void SetLevel(int level)">`SetLevel`</SwmToken> method.

```c#
        /// <summary>
        /// Sets the current level.
        /// </summary>
        /// <param name="level">The level to set.</param>
        public void SetLevel(int level)
        {
            _level = level;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" line="26">

---

## Increasing the Level

The level can be increased using the <SwmToken path="unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" pos="29:5:5" line-data="        public void LevelUp()">`LevelUp`</SwmToken> method.

```c#
        /// <summary>
        /// Increases the level by one.
        /// </summary>
        public void LevelUp()
        {
            _level++;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" line="34">

---

## Resetting the Level

The level can be reset to 1 using the <SwmToken path="unity/four-block/Assets/game/logic/LevelBasedGravityStrategy.cs" pos="37:5:5" line-data="        public void ResetLevel()">`ResetLevel`</SwmToken> method.

```c#
        /// <summary>
        /// resets the level to 1.
        /// </summary>
        public void ResetLevel()
        {
            _level = 1;
        } 
```

---

</SwmSnippet>

*This is an auto-generated document by Swimm AI 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBREVNTy1ncmF2aXR5LWN1YmVzJTNBJTNBc3dpbW1pbw==" repo-name="DEMO-gravity-cubes"><sup>Powered by [Swimm](https://staging.swimm.cloud/)</sup></SwmMeta>
