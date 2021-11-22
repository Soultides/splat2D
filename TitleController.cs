using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    public float timeMin = 0.5f;
    public float timeMax = 2f;

    public ParticleSystem ps;

    public Transform Splat1;
    public Transform Splat2;
    public Transform Splat3;
    public Transform Splat4;
    public Transform Splat5;
    public Transform Splat6;
    public Transform Splat7;
    public Transform Splat8;
    public Transform Splat9;
    public Transform Splat10;
    public Transform Splat11;
    public Transform Splat12;
    public Transform Splat13;
    public Transform Splat14;
    public Transform Splat15;
    public Transform Splat16;
    public Transform Splat17;
    public Transform Splat18;
    public Transform Splat19;
    public Transform Splat20;
    public Transform Splat21;
    public Transform Splat22;
    public Transform Splat23;
    public Transform Splat24;
    public Transform Splat25;
    public Transform SplatPlay;
    public Transform SplatPlay2;
    private void Start()
    {
        StartCoroutine(Splatter());
    }

    public IEnumerator Splatter()
    {
        float timeDelay = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay);
        Instantiate(ps, Splat1.transform.position, Splat1.transform.rotation);

        float timeDelay2 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay2);
        Instantiate(ps, Splat2.transform.position, Splat2.transform.rotation);

        float timeDelay3 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay3);
        Instantiate(ps, Splat3.transform.position, Splat3.transform.rotation);

        float timeDelay4 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay4);
        Instantiate(ps, Splat4.transform.position, Splat4.transform.rotation);

        float timeDelay5 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay5);
        Instantiate(ps, Splat5.transform.position, Splat5.transform.rotation);

        float timeDelay6 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay6);
        Instantiate(ps, Splat6.transform.position, Splat6.transform.rotation);

        float timeDelay7 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay7);
        Instantiate(ps, Splat7.transform.position, Splat7.transform.rotation);

        float timeDelay8 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay8);
        Instantiate(ps, Splat8.transform.position, Splat8.transform.rotation);

        float timeDelay9 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay9);
        Instantiate(ps, Splat9.transform.position, Splat9.transform.rotation);

        float timeDelay10 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay10);
        Instantiate(ps, Splat10.transform.position, Splat10.transform.rotation);

        float timeDelay11 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay11);
        Instantiate(ps, Splat11.transform.position, Splat11.transform.rotation);

        float timeDelay12 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay12);
        Instantiate(ps, Splat12.transform.position, Splat12.transform.rotation);

        float timeDelay13 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay13);
        Instantiate(ps, Splat13.transform.position, Splat13.transform.rotation);

        float timeDelay14 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay14);
        Instantiate(ps, Splat14.transform.position, Splat14.transform.rotation);

        float timeDelay15 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay15);
        Instantiate(ps, Splat15.transform.position, Splat15.transform.rotation);

        float timeDelay16 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay16);
        Instantiate(ps, Splat16.transform.position, Splat16.transform.rotation);

        float timeDelay17 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay17);
        Instantiate(ps, Splat17.transform.position, Splat17.transform.rotation);

        float timeDelay18 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay18);
        Instantiate(ps, Splat18.transform.position, Splat18.transform.rotation);

        float timeDelay19 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay19);
        Instantiate(ps, Splat19.transform.position, Splat19.transform.rotation);

        float timeDelay20 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay20);
        Instantiate(ps, Splat20.transform.position, Splat20.transform.rotation);

        float timeDelay21 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay21);
        Instantiate(ps, Splat21.transform.position, Splat21.transform.rotation);

        float timeDelay22 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay22);
        Instantiate(ps, Splat22.transform.position, Splat22.transform.rotation);

        float timeDelay23 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay23);
        Instantiate(ps, Splat22.transform.position, Splat22.transform.rotation);

        float timeDelay24 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay24);
        Instantiate(ps, Splat24.transform.position, Splat24.transform.rotation);

        float timeDelay25 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay25);
        Instantiate(ps, Splat25.transform.position, Splat25.transform.rotation);

        float timeDelay69 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay69);
        Instantiate(ps, SplatPlay.transform.position, SplatPlay.transform.rotation);

        float timeDelay96 = Random.Range(timeMin, timeMax);
        yield return new WaitForSeconds(timeDelay96);
        Instantiate(ps, SplatPlay2.transform.position, SplatPlay2.transform.rotation);
    }
}
