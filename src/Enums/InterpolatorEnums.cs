namespace InterpolatorEnums
{
    public enum InterpolationModes { Bezier, Tween, Switch, Minimum, Maximum };
    public enum InterpolationModes2 { Bezier, Tween, Switch };
    public enum SwitchModes { Switch, Minimum, Maximum };
    public enum BlendModes { Direct, Add, Multiply, Minimum, Maximum };
    public enum BooleanModes { Direct, OR, AND, NOR, NAND, XOR, XNOR };
    public enum TweenerTransition2 { Linear, Sine, Quad, Cubic, Quart, Quint, Expo, Circular, Elastic, Back, Switch };
    public enum TweenerTransitionFade { Linear, Sine, Quad, Cubic, Quart, Quint, Expo, Circular };
    public enum TargetMode { Minimum, Maximum, NotManaged, Interpolate };
}
