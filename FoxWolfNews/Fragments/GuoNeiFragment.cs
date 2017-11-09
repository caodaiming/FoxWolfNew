using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace FoxWolfNews.Fragments
{
    public class GuoNeiFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static GuoNeiFragment NewInstance()
        {
            return new GuoNeiFragment { Arguments = new Bundle() };
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var ingored = base.OnCreateView(inflater, container, savedInstanceState);

            return inflater.Inflate(Resource.Layout.guoNeiFragment,null);
        }
    }
}