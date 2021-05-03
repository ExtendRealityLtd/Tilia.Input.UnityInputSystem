# Changelog

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
