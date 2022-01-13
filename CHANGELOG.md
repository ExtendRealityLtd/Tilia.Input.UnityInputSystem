# Changelog

### [1.1.14](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.13...v1.1.14) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.41.0 to 1.42.0 ([eb1eafe](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/eb1eafeaf78214de2bf4b273988369625c551481))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.41.0 to 1.42.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.41.0...v1.42.0)

### [1.1.13](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.12...v1.1.13) (2022-01-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.40.0 to 1.41.0 ([2a22a10](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/2a22a10789d4cf3d82c15c67f27980d49890219f))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.40.0 to 1.41.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.40.0...v1.41.0)

### [1.1.12](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.11...v1.1.12) (2022-01-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.39.0 to 1.40.0 ([dce6363](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/dce63637b2ce4b3a37a1330ff51dea1644cb6f06))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.39.0 to 1.40.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.39.0...v1.40.0)

### [1.1.11](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.10...v1.1.11) (2021-12-18)

#### Bug Fixes

* **Samples:** ensure axis values are always broadcast ([0a30d6d](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/0a30d6d8a3bfc56614946778219214638a0be7c6))
  > There was an issue where axis values would sometimes not be broadcast if the axis was released quickly back to its origin value. This seems to be because the `performed` context does not get called when the axis value changes rapidly, but instead the `canceled` context is called instead.
  > 
  > To prevent this from causing an issue, all of the samples axis context processors have now been set to process every context to ensure any slight or rapid changes are picked up.
  > 
  > The input mappings for the axes also now have relevant deadzone processors on them to ensure the min and max values are reached even if the physical axis control cannot reach or report those absolute min or max values.
  > 
  > Because of the use of the built in processes, it means the custom deadzone calculation in the CallbackContextToFloat is no longer required as this should just be handled with the standard deadzone processor anyway.

### [1.1.10](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.9...v1.1.10) (2021-12-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.1 to 1.39.0 ([d24ba6f](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/d24ba6f5d3c4b07ca42160ddfd5eb7bda2dfed7b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.1 to 1.39.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.1...v1.39.0)

### [1.1.9](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.8...v1.1.9) (2021-08-22)

#### Bug Fixes

* **Transformation:** provide deadzone value for float ([6e7c7de](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/6e7c7de31c7669c4c4b9df9ea2070d33e9d491f7))
  > There was an issue where the minimum float value for an axis could be so low that it just wasn't reported by Unity as an action meaning any subsequent action may not get updated due to the value not being recognised as changed.
  > 
  > This fix adds in an extra deadzone value to the float that can be used to set the absolute minimum reported value to consider as zero.

### [1.1.8](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.7...v1.1.8) (2021-07-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.0 to 1.38.1 ([cd28716](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/cd287161200575c9fe8534f76c626b72abe28450))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.0 to 1.38.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.0...v1.38.1)

### [1.1.7](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.6...v1.1.7) (2021-07-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.37.0 to 1.38.0 ([250331c](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/250331cd17f522b00f3d9345ae49b227b0cefae4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.37.0 to 1.38.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.37.0...v1.38.0)

### [1.1.6](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.5...v1.1.6) (2021-06-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.2 to 1.37.0 ([a9e1fa3](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/a9e1fa3b9aa6ed071a02019b183728513b923a55))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.2 to 1.37.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.2...v1.37.0)

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.4...v1.1.5) (2021-06-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.1 to 1.36.2 ([28c6f7c](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/28c6f7c342964a993272fbce0cde8a029ce2b001))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.1 to 1.36.2. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.1...v1.36.2)

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.3...v1.1.4) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.0 to 1.36.1 ([9703d2a](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/9703d2ad175a2171afa5aad67c9cf8b4aeb098fd))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.0 to 1.36.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.0...v1.36.1)
* **README.md:** update title logo to related-media repo ([87bce3f](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/87bce3f5fae9951d0139d6c02489b606a12090d9))
  > The title logo is now located on the related-media repo.

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.2...v1.1.3) (2021-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.35.0 to 1.36.0 ([b8a5b07](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/b8a5b075f17674ad600f30268650ade1a3c549c9))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.35.0 to 1.36.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.35.0...v1.36.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.1...v1.1.2) (2021-05-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.34.1 to 1.35.0 ([0597b1d](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/0597b1d2ee2192856302925904006a6b4a9fa619))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.34.1 to 1.35.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.34.1...v1.35.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.1.0...v1.1.1) (2021-04-15)

#### Bug Fixes

* **package.json:** include Samples~ directory in package build ([0bd3e43](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/0bd3e43371545c1818f36be3349303d247eb780f))
  > The Samples~ directory was not included in the package build so was being omitted from the final build.

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.0.2...v1.1.0) (2021-04-07)

#### Features

* **Samples:** move samples to package manager Samples~ directory ([ccac418](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/ccac4186d644bddb5d482df31b48cad26027d94f))
  > The Unity 2019.1 Package Manager allows for samples to be located in a special `Samples~` root directory which allows the samples to be optionally included with the package at install time. As the Unity Input System package requires at least 2019.1 then this functionality can be used in this package.
  > 
  > The existing `GenericXR` sample has now been moved to this new directory so it can be optionally added to the project if required.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.0.1...v1.0.2) (2021-04-01)

#### Bug Fixes

* **Samples:** switch mappings for right thumbstick and touchpad ([bfa349e](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/bfa349e082b93e141632b206cf7ab0f77f32d894))
  > The mappings for the right thumbstick and touchpad were the wrong way round where the thumbstick would call the touchpad actions and vice versa.
  > 
  > This has now been put the right way round.

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/compare/v1.0.0...v1.0.1) (2021-03-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.1 to 1.33.0 ([b492308](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/b49230844a92ea149c90ca1d2de73cb002f1c10d))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.1 to 1.33.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.1...v1.33.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

## 1.0.0 (2021-03-31)

#### Features

* **structure:** add prefab and base documentation ([3c5d89f](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem/commit/3c5d89f69be77f3465487304caee01e1382fd651))
  > The base XR Plugin Framework camera rig prefab has been added along with the required base documentation.
