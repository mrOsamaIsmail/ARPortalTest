using UnityEngine;

public class TweenedAnimation : MonoBehaviour
{
    [SerializeField] TweenPhase Phase;
    [SerializeField] TweenType Type;
    [SerializeField] LeanTweenType Ease;
    [SerializeField] float time;
    [Space(5)]
    [SerializeField] Vector3 startVal;
    [SerializeField] Vector3 endVal;
    public void DispatchTween()
    {
        switch (Type)
        {
            case TweenType.POSITION:
                LeanTween.move(this.gameObject, endVal, time).setEase(Ease);
                break;
            case TweenType.ROTATE:
                LeanTween.rotate(this.gameObject, endVal, time).setEase(Ease);
                break;
            case TweenType.SCALE:
                LeanTween.scale(this.gameObject, endVal, time).setEase(Ease);
                break;
            default:
                break;
        }
    }
    public void DispatchResetTween()
    {
        switch (Type)
        {
            case TweenType.POSITION:
                LeanTween.move(this.gameObject, startVal, time).setEase(Ease);
                break;
            case TweenType.ROTATE:
                LeanTween.rotate(this.gameObject, startVal, time).setEase(Ease);
                break;
            case TweenType.SCALE:
                LeanTween.scale(this.gameObject, startVal, time).setEase(Ease);
                break;
            default:
                break;
        }
    }

    private void InitStartVal() 
    {
        switch (Type)
        {
            case TweenType.POSITION:
                startVal = transform.position;
                break;
            case TweenType.ROTATE:
                startVal = transform.rotation.eulerAngles;
                break;
            case TweenType.SCALE:
                startVal = transform.localScale;
                break;
            default:
                break;
        }
    }
    private void Awake()
    {

        InitStartVal();
        if (Phase.HasFlag(TweenPhase.AWAKE))
            DispatchTween();
    }
    private void OnEnable()
    {
        if (Phase.HasFlag(TweenPhase.ENABLE))
            DispatchTween();
    }
    private void Start()
    {
        if (Phase.HasFlag(TweenPhase.START))
            DispatchTween();
    }
    private void OnDisable()
    {
        if (Phase.HasFlag(TweenPhase.DISABLE))
            DispatchTween();
    }
    private void OnDestroy()
    {
        if (Phase.HasFlag(TweenPhase.DESTROY))
            DispatchTween();
    }

   
}
