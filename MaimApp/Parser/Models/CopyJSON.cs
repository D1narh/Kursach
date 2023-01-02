using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaimApp.Models
{

    public class Result
    {
        public string jsonrpc { get; set; }
        public Response response { get; set; }
        public object[] errors { get; set; }
        public object[] messages { get; set; }
        public string hash { get; set; }
        public string trace { get; set; }
    }

    public class Response
    {
        public City[] cities { get; set; }
        public Hotel[] hotels { get; set; }
        public object[] additional_hotel_ids { get; set; }
        public bool isMember { get; set; }
    }

    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public string coords_ya { get; set; }
        public string url { get; set; }
        public string genitive { get; set; }
        public string distance { get; set; }
        public string country_name { get; set; }
        public string country_url { get; set; }
        public int hotels_num { get; set; }
        public float[] coords { get; set; }
        public int[] types { get; set; }
        public string local_time { get; set; }
    }

    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public int status { get; set; }
        public string address { get; set; }
        public int has_debt { get; set; }
        public Times times { get; set; }
        public string in_time { get; set; }
        public int type_id { get; set; }
        public int category_id { get; set; }
        public int[] type_ids { get; set; }
        public int[] category_ids { get; set; }
        public int city_id { get; set; }
        public int region_id { get; set; }
        public string city_name { get; set; }
        public string city_url { get; set; }
        public int country_id { get; set; }
        public string country_url { get; set; }
        public string country_name { get; set; }
        public int district_id { get; set; }
        public int?[] district_ids { get; set; }
        public int stars { get; set; }
        public int breakfast { get; set; }
        public int breakfast_price { get; set; }
        public int half_board { get; set; }
        public int full_board { get; set; }
        public int all_inclusive { get; set; }
        public string url { get; set; }
        public string alt_name { get; set; }
        public int leader { get; set; }
        public int partner { get; set; }
        public int top { get; set; }
        public int partner_by_fee { get; set; }
        public int partner_by_adv { get; set; }
        public int adv { get; set; }
        public int weight { get; set; }
        public int supplier { get; set; }
        public int fixed_quota { get; set; }
        public int sales_closed { get; set; }
        public string type_name { get; set; }
        public string type_accusative { get; set; }
        public int show_type { get; set; }
        public float min_price { get; set; }
        public int position { get; set; }
        public string coords_ya { get; set; }
        public int rooms_num { get; set; }
        public float rating { get; set; }
        public int number_reviews { get; set; }
        public Reviews_Summary reviews_summary { get; set; }
        public string currency { get; set; }
        public int booked { get; set; }
        public int bookable { get; set; }
        public int _readonly { get; set; }
        public int show_phones { get; set; }
        public int opening_date { get; set; }
        public int overhaul_date { get; set; }
        public int opening_or_overhaul_date { get; set; }
        public int floors_num { get; set; }
        public float[] coords { get; set; }
        public Map map { get; set; }
        public float center_distance { get; set; }
        public string panorama_position { get; set; }
        public int show_nearest_panorama { get; set; }
        public int chain_id { get; set; }
        public int state_hotel { get; set; }
        public object[] virtual_tours { get; set; }
        public Image image { get; set; }
        public Image1[] images { get; set; }
        public Image_Pool image_pool { get; set; }
        public object image_winter { get; set; }
        public object facilities { get; set; }
        public Distances distances { get; set; }
        public Facility_Distance facility_distance { get; set; }
        public int?[] services { get; set; }
        public int?[] service_categories { get; set; }
        public int sea_views { get; set; }
        public object conference_hall { get; set; }
        public int?[] rooms { get; set; }
        public object rooms_amenities { get; set; }
        public int has_rooms_with_bathroom { get; set; }
        public int has_placements_with_breakfast_buffet { get; set; }
        public object[] special_offers { get; set; }
        public int payment { get; set; }
        public int cards { get; set; }
        public int pets { get; set; }
        public int pet_weight { get; set; }
        public int forced_real_phone { get; set; }
        public string[] phones { get; set; }
        public int pageviews { get; set; }
        public int distance_to_sea { get; set; }
        public Area[] areas { get; set; }
        public object sea_distances { get; set; }
        public string[] languages { get; set; }
        public float original_rating { get; set; }
        public Booking_Areas[] booking_areas { get; set; }
        public Displayed_Phones displayed_phones { get; set; }
        public int popular { get; set; }
        public Min_Price_Data min_price_data { get; set; }
        public Category_Index category_index { get; set; }
        public object rel_owner { get; set; }
        public Valid_Filter valid_filter { get; set; }
        public int views { get; set; }
        public int supplier_id { get; set; }
        public int supplier_closed { get; set; }
        public int ad_type { get; set; }
    }

    public class Times
    {
        public string in_from { get; set; }
        public string in_to { get; set; }
        public string out_from { get; set; }
        public string out_to { get; set; }
    }

    public class Reviews_Summary
    {
        public int number_reviews { get; set; }
        public int number_scores { get; set; }
        public float rating { get; set; }
        public float quality_of_sleep { get; set; }
        public float location { get; set; }
        public float service { get; set; }
        public float value_for_money { get; set; }
        public float cleanness { get; set; }
        public float meal { get; set; }
    }

    public class Map
    {
        public int tile0 { get; set; }
        public int tile1 { get; set; }
        public int tile2 { get; set; }
        public int tile3 { get; set; }
        public int tile4 { get; set; }
    }

    public class Image
    {
        public string path { get; set; }
        public string thumb_path { get; set; }
        public string preview_path { get; set; }
        public string mobile_path { get; set; }
        public string mobile_preview_path { get; set; }
    }

    public class Image_Pool
    {
        public string path { get; set; }
        public string thumb_path { get; set; }
        public string preview_path { get; set; }
    }

    public class Distances
    {
        public _2[] _2 { get; set; }
        public _3[] _3 { get; set; }
        public _4[] _4 { get; set; }
        public _11[] _11 { get; set; }
        public _16[] _16 { get; set; }
        public _24[] _24 { get; set; }
        public _34[] _34 { get; set; }
        public _35[] _35 { get; set; }
        public _38[] _38 { get; set; }
        public _47[] _47 { get; set; }
        public _61[] _61 { get; set; }
        public _66[] _66 { get; set; }
        public _44[] _44 { get; set; }
        public _8[] _8 { get; set; }
        public _9[] _9 { get; set; }
        public _13[] _13 { get; set; }
        public _14[] _14 { get; set; }
        public _54[] _54 { get; set; }
        public _65[] _65 { get; set; }
        public _15[] _15 { get; set; }
        public _19[] _19 { get; set; }
        public _20[] _20 { get; set; }
        public _22[] _22 { get; set; }
        public _23[] _23 { get; set; }
        public _25[] _25 { get; set; }
        public _26[] _26 { get; set; }
        public _30[] _30 { get; set; }
        public _53[] _53 { get; set; }
        public _59[] _59 { get; set; }
        public _68[] _68 { get; set; }
        public _10[] _10 { get; set; }
        public _17[] _17 { get; set; }
        public _31[] _31 { get; set; }
        public _62[] _62 { get; set; }
        public _46[] _46 { get; set; }
        public _21[] _21 { get; set; }
        public _18[] _18 { get; set; }
        public _32[] _32 { get; set; }
        public _57[] _57 { get; set; }
        public _71[] _71 { get; set; }
        public _69[] _69 { get; set; }
        public _48[] _48 { get; set; }
        public _49[] _49 { get; set; }
        public _39[] _39 { get; set; }
        public _42[] _42 { get; set; }
        public _45[] _45 { get; set; }
        public _33[] _33 { get; set; }
    }

    public class _2
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _3
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _4
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _11
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _16
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _24
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _34
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _35
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _38
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _47
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _61
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _66
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _44
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _8
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _9
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _13
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _14
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _54
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _65
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _15
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _19
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _20
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _22
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _23
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _25
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _26
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _30
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _53
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _59
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _68
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _10
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _17
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _31
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _62
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _46
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _21
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _18
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _32
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _57
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _71
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _69
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _48
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _49
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _39
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _42
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _45
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class _33
    {
        public int id { get; set; }
        public int distance { get; set; }
    }

    public class Facility_Distance
    {
        public int _74 { get; set; }
        public int _137 { get; set; }
        public int _70 { get; set; }
        public int _132 { get; set; }
        public int _138 { get; set; }
        public int _73 { get; set; }
        public int _318 { get; set; }
        public int _23028 { get; set; }
        public int _3862 { get; set; }
        public int _8102 { get; set; }
        public int _314 { get; set; }
        public int _6583 { get; set; }
        public int _540 { get; set; }
        public int _10058 { get; set; }
        public int _447 { get; set; }
        public int _502 { get; set; }
        public int _326 { get; set; }
        public int _322 { get; set; }
        public int _319 { get; set; }
        public int _321 { get; set; }
        public int _324 { get; set; }
        public int _317 { get; set; }
        public int _313 { get; set; }
        public int _315 { get; set; }
        public int _320 { get; set; }
        public int _6288 { get; set; }
        public int _6289 { get; set; }
        public int _4488 { get; set; }
        public int _9361 { get; set; }
        public int _8964 { get; set; }
        public int _6922 { get; set; }
        public int _10672 { get; set; }
        public int _12821 { get; set; }
        public int _9533 { get; set; }
        public int _8767 { get; set; }
        public int _9394 { get; set; }
        public int _6291 { get; set; }
        public int _13499 { get; set; }
        public int _12875 { get; set; }
        public int _9519 { get; set; }
        public int _12671 { get; set; }
        public int _13365 { get; set; }
        public int _10304 { get; set; }
        public int _13286 { get; set; }
        public int _12089 { get; set; }
        public int _9422 { get; set; }
        public int _10596 { get; set; }
        public int _3872 { get; set; }
        public int _13647 { get; set; }
        public int _16390 { get; set; }
        public int _10423 { get; set; }
        public int _12775 { get; set; }
        public int _6290 { get; set; }
        public int _4493 { get; set; }
        public int _9071 { get; set; }
        public int _12760 { get; set; }
        public int _9910 { get; set; }
        public int _10560 { get; set; }
        public int _13404 { get; set; }
        public int _12963 { get; set; }
        public int _12716 { get; set; }
        public int _19470 { get; set; }
        public int _11263 { get; set; }
        public int _12898 { get; set; }
        public int _6298 { get; set; }
        public int _13373 { get; set; }
        public int _14425 { get; set; }
        public int _13327 { get; set; }
        public int _5594 { get; set; }
        public int _6369 { get; set; }
        public int _12868 { get; set; }
        public int _12782 { get; set; }
        public int _9319 { get; set; }
        public int _6168 { get; set; }
        public int _10086 { get; set; }
        public int _9539 { get; set; }
        public int _6875 { get; set; }
        public int _4043 { get; set; }
        public int _2567 { get; set; }
        public int _4086 { get; set; }
        public int _8749 { get; set; }
        public int _9546 { get; set; }
        public int _9277 { get; set; }
        public int _10027 { get; set; }
        public int _7671 { get; set; }
        public int _12902 { get; set; }
        public int _10347 { get; set; }
        public int _12827 { get; set; }
        public int _16848 { get; set; }
        public int _10394 { get; set; }
        public int _12785 { get; set; }
        public int _19483 { get; set; }
        public int _13452 { get; set; }
        public int _13441 { get; set; }
        public int _14102 { get; set; }
        public int _13382 { get; set; }
        public int _11459 { get; set; }
        public int _886 { get; set; }
        public int _785 { get; set; }
        public int _22802 { get; set; }
        public int _8141 { get; set; }
        public int _1224 { get; set; }
        public int _1222 { get; set; }
        public int _23814 { get; set; }
        public int _6493 { get; set; }
        public int _6494 { get; set; }
        public int _6447 { get; set; }
        public int _6496 { get; set; }
        public int _6491 { get; set; }
        public int _6495 { get; set; }
        public int _6488 { get; set; }
        public int _6490 { get; set; }
        public int _6492 { get; set; }
        public int _6489 { get; set; }
        public int _6292 { get; set; }
        public int _6293 { get; set; }
        public int _6294 { get; set; }
        public int _6295 { get; set; }
        public int _6296 { get; set; }
        public int _19854 { get; set; }
        public int _19945 { get; set; }
        public int _19948 { get; set; }
        public int _23921 { get; set; }
        public int _23848 { get; set; }
        public int _7267 { get; set; }
        public int _7266 { get; set; }
        public int _7268 { get; set; }
        public int _7269 { get; set; }
        public int _7228 { get; set; }
        public int _7265 { get; set; }
        public int _94 { get; set; }
        public int _16772 { get; set; }
        public int _123 { get; set; }
        public int _96 { get; set; }
        public int _16773 { get; set; }
        public int _110 { get; set; }
        public int _155 { get; set; }
        public int _3927 { get; set; }
        public int _823 { get; set; }
        public int _910 { get; set; }
        public int _861 { get; set; }
        public int _8007 { get; set; }
        public int _8008 { get; set; }
        public int _18710 { get; set; }
        public int _18950 { get; set; }
        public int _19351 { get; set; }
        public int _18849 { get; set; }
        public int _19753 { get; set; }
        public int _19516 { get; set; }
        public int _24013 { get; set; }
        public int _24104 { get; set; }
        public int _23852 { get; set; }
        public int _10643 { get; set; }
        public int _10569 { get; set; }
        public int _149 { get; set; }
        public int _153 { get; set; }
        public int _156 { get; set; }
        public int _135 { get; set; }
        public int _76 { get; set; }
        public int _148 { get; set; }
        public int _150 { get; set; }
        public int _3929 { get; set; }
        public int _143 { get; set; }
        public int _157 { get; set; }
        public int _125 { get; set; }
        public int _124 { get; set; }
        public int _144 { get; set; }
        public int _142 { get; set; }
        public int _3928 { get; set; }
        public int _253 { get; set; }
        public int _126 { get; set; }
        public int _1181 { get; set; }
        public int _1135 { get; set; }
        public int _1192 { get; set; }
        public int _1155 { get; set; }
        public int _1156 { get; set; }
        public int _897 { get; set; }
        public int _1193 { get; set; }
        public int _1211 { get; set; }
        public int _1134 { get; set; }
        public int _1020 { get; set; }
        public int _1213 { get; set; }
        public int _914 { get; set; }
        public int _1128 { get; set; }
        public int _915 { get; set; }
        public int _1097 { get; set; }
        public int _736 { get; set; }
        public int _1094 { get; set; }
        public int _1226 { get; set; }
        public int _894 { get; set; }
        public int _824 { get; set; }
        public int _739 { get; set; }
        public int _1195 { get; set; }
        public int _1176 { get; set; }
        public int _799 { get; set; }
        public int _975 { get; set; }
        public int _1067 { get; set; }
        public int _852 { get; set; }
        public int _1077 { get; set; }
        public int _855 { get; set; }
        public int _903 { get; set; }
        public int _946 { get; set; }
        public int _792 { get; set; }
        public int _22589 { get; set; }
        public int _9816 { get; set; }
        public int _8017 { get; set; }
        public int _8024 { get; set; }
        public int _8018 { get; set; }
        public int _8071 { get; set; }
        public int _5084 { get; set; }
        public int _5088 { get; set; }
        public int _8065 { get; set; }
        public int _8059 { get; set; }
        public int _5020 { get; set; }
        public int _5087 { get; set; }
        public int _8070 { get; set; }
        public int _639 { get; set; }
        public int _8047 { get; set; }
        public int _651 { get; set; }
        public int _713 { get; set; }
        public int _22489 { get; set; }
        public int _4108 { get; set; }
        public int _4116 { get; set; }
        public int _19723 { get; set; }
        public int _19841 { get; set; }
        public int _19758 { get; set; }
        public int _9826 { get; set; }
        public int _18594 { get; set; }
        public int _18659 { get; set; }
        public int _18686 { get; set; }
        public int _18711 { get; set; }
        public int _18601 { get; set; }
        public int _18644 { get; set; }
        public int _18700 { get; set; }
        public int _18693 { get; set; }
        public int _18617 { get; set; }
        public int _18627 { get; set; }
        public int _18611 { get; set; }
        public int _18630 { get; set; }
        public int _18671 { get; set; }
        public int _19586 { get; set; }
        public int _19619 { get; set; }
        public int _620 { get; set; }
        public int _22590 { get; set; }
        public int _22588 { get; set; }
        public int _22593 { get; set; }
        public int _23208 { get; set; }
        public int _24021 { get; set; }
        public int _23999 { get; set; }
        public int _23861 { get; set; }
        public int _24339 { get; set; }
        public int _205 { get; set; }
        public int _18536 { get; set; }
        public int _18535 { get; set; }
        public int _72 { get; set; }
        public int _69 { get; set; }
        public int _18537 { get; set; }
        public int _67 { get; set; }
        public int _832 { get; set; }
        public int _18713 { get; set; }
        public int _719 { get; set; }
        public int _20065 { get; set; }
        public int _3930 { get; set; }
        public int _128 { get; set; }
        public int _152 { get; set; }
        public int _122 { get; set; }
        public int _280 { get; set; }
        public int _188 { get; set; }
        public int _198 { get; set; }
        public int _121 { get; set; }
        public int _151 { get; set; }
        public int _127 { get; set; }
        public int _3945 { get; set; }
        public int _159 { get; set; }
        public int _130 { get; set; }
        public int _189 { get; set; }
        public int _1174 { get; set; }
        public int _756 { get; set; }
        public int _1060 { get; set; }
        public int _1227 { get; set; }
        public int _835 { get; set; }
        public int _1000 { get; set; }
        public int _9828 { get; set; }
        public int _5953 { get; set; }
        public int _884 { get; set; }
        public int _1071 { get; set; }
        public int _22521 { get; set; }
        public int _9815 { get; set; }
        public int _8023 { get; set; }
        public int _834 { get; set; }
        public int _710 { get; set; }
        public int _4628 { get; set; }
        public int _19978 { get; set; }
        public int _19863 { get; set; }
        public int _19712 { get; set; }
        public int _19547 { get; set; }
        public int _23853 { get; set; }
        public int _134 { get; set; }
        public int _158 { get; set; }
        public int _141 { get; set; }
        public int _3941 { get; set; }
        public int _120 { get; set; }
        public int _279 { get; set; }
        public int _269 { get; set; }
        public int _3942 { get; set; }
        public int _140 { get; set; }
        public int _118 { get; set; }
        public int _154 { get; set; }
        public int _895 { get; set; }
        public int _1208 { get; set; }
        public int _870 { get; set; }
        public int _906 { get; set; }
        public int _869 { get; set; }
        public int _740 { get; set; }
        public int _916 { get; set; }
        public int _1095 { get; set; }
        public int _896 { get; set; }
        public int _1230 { get; set; }
        public int _1056 { get; set; }
        public int _1228 { get; set; }
        public int _1019 { get; set; }
        public int _742 { get; set; }
        public int _627 { get; set; }
        public int _753 { get; set; }
        public int _754 { get; set; }
        public int _827 { get; set; }
        public int _743 { get; set; }
        public int _1157 { get; set; }
        public int _961 { get; set; }
        public int _758 { get; set; }
        public int _806 { get; set; }
        public int _729 { get; set; }
        public int _909 { get; set; }
        public int _8265 { get; set; }
        public int _8153 { get; set; }
        public int _8154 { get; set; }
        public int _645 { get; set; }
        public int _8151 { get; set; }
        public int _880 { get; set; }
        public int _976 { get; set; }
        public int _851 { get; set; }
        public int _798 { get; set; }
        public int _904 { get; set; }
        public int _1033 { get; set; }
        public int _854 { get; set; }
        public int _977 { get; set; }
        public int _784 { get; set; }
        public int _905 { get; set; }
        public int _947 { get; set; }
        public int _921 { get; set; }
        public int _932 { get; set; }
        public int _624 { get; set; }
        public int _1070 { get; set; }
        public int _902 { get; set; }
        public int _763 { get; set; }
        public int _22504 { get; set; }
        public int _8080 { get; set; }
        public int _4686 { get; set; }
        public int _8082 { get; set; }
        public int _8074 { get; set; }
        public int _8073 { get; set; }
        public int _640 { get; set; }
        public int _8019 { get; set; }
        public int _5017 { get; set; }
        public int _5012 { get; set; }
        public int _8064 { get; set; }
        public int _5082 { get; set; }
        public int _5011 { get; set; }
        public int _5019 { get; set; }
        public int _8061 { get; set; }
        public int _23613 { get; set; }
        public int _732 { get; set; }
        public int _737 { get; set; }
        public int _4684 { get; set; }
        public int _5078 { get; set; }
        public int _5013 { get; set; }
        public int _5014 { get; set; }
        public int _8044 { get; set; }
        public int _8148 { get; set; }
        public int _1206 { get; set; }
        public int _1205 { get; set; }
        public int _8129 { get; set; }
        public int _22167 { get; set; }
        public int _1149 { get; set; }
        public int _892 { get; set; }
        public int _4602 { get; set; }
        public int _18796 { get; set; }
        public int _18789 { get; set; }
        public int _19711 { get; set; }
        public int _19837 { get; set; }
        public int _9825 { get; set; }
        public int _18625 { get; set; }
        public int _18613 { get; set; }
        public int _18597 { get; set; }
        public int _18592 { get; set; }
        public int _18646 { get; set; }
        public int _18636 { get; set; }
        public int _18672 { get; set; }
        public int _19591 { get; set; }
        public int _19622 { get; set; }
        public int _19629 { get; set; }
        public int _19679 { get; set; }
        public int _19673 { get; set; }
        public int _19702 { get; set; }
        public int _22598 { get; set; }
        public int _24002 { get; set; }
        public int _22599 { get; set; }
        public int _23898 { get; set; }
        public int _24011 { get; set; }
        public int _24012 { get; set; }
        public int _22601 { get; set; }
        public int _23907 { get; set; }
        public int _23990 { get; set; }
        public int _23886 { get; set; }
        public int _24009 { get; set; }
        public int _24015 { get; set; }
        public int _23995 { get; set; }
        public int _23994 { get; set; }
        public int _24020 { get; set; }
        public int _24018 { get; set; }
        public int _24007 { get; set; }
        public int _22653 { get; set; }
        public int _24117 { get; set; }
        public int _24107 { get; set; }
        public int _23869 { get; set; }
        public int _23858 { get; set; }
        public int _24333 { get; set; }
        public int _24328 { get; set; }
        public int _24330 { get; set; }
        public int _103 { get; set; }
        public int _99 { get; set; }
        public int _18533 { get; set; }
        public int _102 { get; set; }
        public int _23889 { get; set; }
        public int _1162 { get; set; }
        public int _981 { get; set; }
        public int _1057 { get; set; }
        public int _815 { get; set; }
        public int _4954 { get; set; }
        public int _7993 { get; set; }
        public int _24133 { get; set; }
        public int _1207 { get; set; }
        public int _4113 { get; set; }
        public int _625 { get; set; }
        public int _19616 { get; set; }
        public int _19563 { get; set; }
        public int _23737 { get; set; }
        public int _23743 { get; set; }
        public int _161 { get; set; }
        public int _165 { get; set; }
        public int _3944 { get; set; }
        public int _129 { get; set; }
        public int _997 { get; set; }
        public int _1062 { get; set; }
        public int _17394 { get; set; }
        public int _22533 { get; set; }
        public int _1185 { get; set; }
        public int _21151 { get; set; }
        public int _18670 { get; set; }
        public int _19672 { get; set; }
        public int _19686 { get; set; }
        public int _19674 { get; set; }
        public int _23926 { get; set; }
        public int _872 { get; set; }
        public int _652 { get; set; }
        public int _755 { get; set; }
        public int _1061 { get; set; }
        public int _1090 { get; set; }
        public int _829 { get; set; }
        public int _395 { get; set; }
        public int _17267 { get; set; }
        public int _793 { get; set; }
        public int _22338 { get; set; }
        public int _8084 { get; set; }
        public int _8078 { get; set; }
        public int _633 { get; set; }
        public int _8144 { get; set; }
        public int _8145 { get; set; }
        public int _8015 { get; set; }
        public int _8022 { get; set; }
        public int _8020 { get; set; }
        public int _5083 { get; set; }
        public int _647 { get; set; }
        public int _705 { get; set; }
        public int _18794 { get; set; }
        public int _18626 { get; set; }
        public int _3943 { get; set; }
        public int _133 { get; set; }
        public int _821 { get; set; }
        public int _5775 { get; set; }
        public int _996 { get; set; }
        public int _900 { get; set; }
        public int _813 { get; set; }
        public int _825 { get; set; }
        public int _898 { get; set; }
        public int _817 { get; set; }
        public int _17270 { get; set; }
        public int _17272 { get; set; }
        public int _1036 { get; set; }
        public int _1043 { get; set; }
        public int _933 { get; set; }
        public int _795 { get; set; }
        public int _23189 { get; set; }
        public int _1225 { get; set; }
        public int _8147 { get; set; }
        public int _8133 { get; set; }
        public int _24681 { get; set; }
        public int _23828 { get; set; }
        public int _20023 { get; set; }
        public int _19550 { get; set; }
        public int _18648 { get; set; }
        public int _19564 { get; set; }
        public int _24017 { get; set; }
        public int _23993 { get; set; }
        public int _23206 { get; set; }
        public int _24326 { get; set; }
        public int _104 { get; set; }
        public int _1126 { get; set; }
        public int _1131 { get; set; }
        public int _711 { get; set; }
        public int _658 { get; set; }
        public int _8113 { get; set; }
        public int _8108 { get; set; }
        public int _4084 { get; set; }
        public int _19865 { get; set; }
        public int _19625 { get; set; }
        public int _24334 { get; set; }
        public int _18528 { get; set; }
        public int _115 { get; set; }
        public int _18527 { get; set; }
        public int _92 { get; set; }
        public int _18529 { get; set; }
        public int _91 { get; set; }
        public int _114 { get; set; }
        public int _93 { get; set; }
        public int _1210 { get; set; }
        public int _875 { get; set; }
        public int _8137 { get; set; }
        public int _19926 { get; set; }
        public int _17897 { get; set; }
        public int _18746 { get; set; }
        public int _539 { get; set; }
        public int _19700 { get; set; }
        public int _4606 { get; set; }
        public int _6586 { get; set; }
        public int _6923 { get; set; }
        public int _7679 { get; set; }
        public int _19835 { get; set; }
        public int _19707 { get; set; }
        public int _23972 { get; set; }
        public int _4115 { get; set; }
        public int _18608 { get; set; }
        public int _18593 { get; set; }
        public int _18696 { get; set; }
        public int _281 { get; set; }
        public int _837 { get; set; }
        public int _1021 { get; set; }
        public int _980 { get; set; }
        public int _1229 { get; set; }
        public int _816 { get; set; }
        public int _731 { get; set; }
        public int _843 { get; set; }
        public int _765 { get; set; }
        public int _1073 { get; set; }
        public int _22587 { get; set; }
        public int _22522 { get; set; }
        public int _5085 { get; set; }
        public int _8058 { get; set; }
        public int _1220 { get; set; }
        public int _8132 { get; set; }
        public int _1103 { get; set; }
        public int _3825 { get; set; }
        public int _21157 { get; set; }
        public int _18653 { get; set; }
        public int _19601 { get; set; }
        public int _19571 { get; set; }
        public int _24005 { get; set; }
        public int _24010 { get; set; }
        public int _24014 { get; set; }
        public int _24307 { get; set; }
        public int _18522 { get; set; }
        public int _18521 { get; set; }
        public int _18523 { get; set; }
        public int _199 { get; set; }
        public int _18817 { get; set; }
        public int _22581 { get; set; }
        public int _23581 { get; set; }
        public int _19680 { get; set; }
        public int _19675 { get; set; }
        public int _139 { get; set; }
        public int _836 { get; set; }
        public int _936 { get; set; }
        public int _803 { get; set; }
        public int _1139 { get; set; }
        public int _8149 { get; set; }
        public int _5951 { get; set; }
        public int _8262 { get; set; }
        public int _8152 { get; set; }
        public int _923 { get; set; }
        public int _760 { get; set; }
        public int _845 { get; set; }
        public int _850 { get; set; }
        public int _800 { get; set; }
        public int _866 { get; set; }
        public int _8003 { get; set; }
        public int _4685 { get; set; }
        public int _17301 { get; set; }
        public int _634 { get; set; }
        public int _638 { get; set; }
        public int _4683 { get; set; }
        public int _5080 { get; set; }
        public int _8067 { get; set; }
        public int _5079 { get; set; }
        public int _5077 { get; set; }
        public int _1187 { get; set; }
        public int _1188 { get; set; }
        public int _1203 { get; set; }
        public int _8043 { get; set; }
        public int _643 { get; set; }
        public int _22166 { get; set; }
        public int _654 { get; set; }
        public int _8127 { get; set; }
        public int _1101 { get; set; }
        public int _4109 { get; set; }
        public int _9890 { get; set; }
        public int _9265 { get; set; }
        public int _9891 { get; set; }
        public int _18793 { get; set; }
        public int _9893 { get; set; }
        public int _19791 { get; set; }
        public int _19592 { get; set; }
        public int _18607 { get; set; }
        public int _18619 { get; set; }
        public int _9822 { get; set; }
        public int _19691 { get; set; }
        public int _19597 { get; set; }
        public int _23198 { get; set; }
        public int _23893 { get; set; }
        public int _23902 { get; set; }
        public int _23903 { get; set; }
        public int _23923 { get; set; }
        public int _23207 { get; set; }
        public int _23892 { get; set; }
        public int _22600 { get; set; }
        public int _23896 { get; set; }
        public int _23992 { get; set; }
        public int _24019 { get; set; }
        public int _22595 { get; set; }
        public int _23997 { get; set; }
        public int _22651 { get; set; }
        public int _24115 { get; set; }
        public int _24114 { get; set; }
        public int _23867 { get; set; }
        public int _24332 { get; set; }
        public int _24337 { get; set; }
        public int _24325 { get; set; }
        public int _1212 { get; set; }
        public int _716 { get; set; }
        public int _621 { get; set; }
        public int _805 { get; set; }
        public int _808 { get; set; }
        public int _17268 { get; set; }
        public int _17273 { get; set; }
        public int _17283 { get; set; }
        public int _8076 { get; set; }
        public int _8066 { get; set; }
        public int _9889 { get; set; }
        public int _18669 { get; set; }
        public int _23996 { get; set; }
        public int _23895 { get; set; }
        public int _22674 { get; set; }
        public int _24335 { get; set; }
        public int _23559 { get; set; }
        public int _117 { get; set; }
        public int _715 { get; set; }
        public int _937 { get; set; }
        public int _789 { get; set; }
        public int _1003 { get; set; }
        public int _950 { get; set; }
        public int _887 { get; set; }
        public int _901 { get; set; }
        public int _978 { get; set; }
        public int _1039 { get; set; }
        public int _787 { get; set; }
        public int _796 { get; set; }
        public int _948 { get; set; }
        public int _1068 { get; set; }
        public int _22524 { get; set; }
        public int _22501 { get; set; }
        public int _641 { get; set; }
        public int _1200 { get; set; }
        public int _8111 { get; set; }
        public int _20053 { get; set; }
        public int _19888 { get; set; }
        public int _18709 { get; set; }
        public int _18631 { get; set; }
        public int _18616 { get; set; }
        public int _18622 { get; set; }
        public int _19614 { get; set; }
        public int _19583 { get; set; }
        public int _24001 { get; set; }
        public int _22585 { get; set; }
        public int _23924 { get; set; }
        public int _24112 { get; set; }
        public int _24110 { get; set; }
        public int _24101 { get; set; }
        public int _24121 { get; set; }
        public int _24338 { get; set; }
        public int _24312 { get; set; }
        public int _22342 { get; set; }
        public int _254 { get; set; }
        public int _16776 { get; set; }
        public int _88 { get; set; }
        public int _16775 { get; set; }
        public int _87 { get; set; }
        public int _23193 { get; set; }
        public int _17265 { get; set; }
        public int _22517 { get; set; }
        public int _22503 { get; set; }
        public int _22344 { get; set; }
        public int _24129 { get; set; }
        public int _8016 { get; set; }
        public int _8060 { get; set; }
        public int _23580 { get; set; }
        public int _4607 { get; set; }
        public int _747 { get; set; }
        public int _18623 { get; set; }
        public int _18676 { get; set; }
        public int _23202 { get; set; }
        public int _23986 { get; set; }
        public int _23871 { get; set; }
        public int _24321 { get; set; }
        public int _145 { get; set; }
        public int _1059 { get; set; }
        public int _22161 { get; set; }
        public int _1092 { get; set; }
        public int _804 { get; set; }
        public int _807 { get; set; }
        public int _1007 { get; set; }
        public int _8083 { get; set; }
        public int _631 { get; set; }
        public int _635 { get; set; }
        public int _8013 { get; set; }
        public int _5016 { get; set; }
        public int _8105 { get; set; }
        public int _19524 { get; set; }
        public int _19559 { get; set; }
        public int _19831 { get; set; }
        public int _18684 { get; set; }
        public int _18702 { get; set; }
        public int _18621 { get; set; }
        public int _18708 { get; set; }
        public int _18635 { get; set; }
        public int _18651 { get; set; }
        public int _18674 { get; set; }
        public int _18632 { get; set; }
        public int _18683 { get; set; }
        public int _18634 { get; set; }
        public int _18596 { get; set; }
        public int _18661 { get; set; }
        public int _18682 { get; set; }
        public int _18685 { get; set; }
        public int _18595 { get; set; }
        public int _18689 { get; set; }
        public int _19613 { get; set; }
        public int _19501 { get; set; }
        public int _19527 { get; set; }
        public int _23851 { get; set; }
        public int _22336 { get; set; }
        public int _1004 { get; set; }
        public int _1202 { get; set; }
        public int _8125 { get; set; }
        public int _4112 { get; set; }
        public int _18798 { get; set; }
        public int _3821 { get; set; }
        public int _23070 { get; set; }
        public int _19920 { get; set; }
        public int _18603 { get; set; }
        public int _18645 { get; set; }
        public int _18638 { get; set; }
        public int _18687 { get; set; }
        public int _18667 { get; set; }
        public int _18688 { get; set; }
        public int _19532 { get; set; }
        public int _23985 { get; set; }
        public int _24016 { get; set; }
        public int _22652 { get; set; }
        public int _22648 { get; set; }
        public int _22662 { get; set; }
        public int _24008 { get; set; }
        public int _876 { get; set; }
        public int _8150 { get; set; }
        public int _1074 { get; set; }
        public int _8124 { get; set; }
        public int _1098 { get; set; }
        public int _1132 { get; set; }
        public int _4079 { get; set; }
        public int _18602 { get; set; }
        public int _18654 { get; set; }
        public int _18699 { get; set; }
        public int _18633 { get; set; }
        public int _18629 { get; set; }
        public int _18698 { get; set; }
        public int _18610 { get; set; }
        public int _18704 { get; set; }
        public int _18701 { get; set; }
        public int _18606 { get; set; }
        public int _24003 { get; set; }
        public int _23989 { get; set; }
        public int _467 { get; set; }
        public int _10675 { get; set; }
        public int _19612 { get; set; }
        public int _17271 { get; set; }
        public int _1046 { get; set; }
        public int _24122 { get; set; }
        public int _1184 { get; set; }
        public int _19492 { get; set; }
        public int _18678 { get; set; }
        public int _18664 { get; set; }
        public int _18643 { get; set; }
        public int _18665 { get; set; }
        public int _24120 { get; set; }
        public int _23855 { get; set; }
        public int _3939 { get; set; }
        public int _14600 { get; set; }
        public int _12789 { get; set; }
        public int _10366 { get; set; }
        public int _6573 { get; set; }
        public int _19947 { get; set; }
        public int _195 { get; set; }
        public int _194 { get; set; }
        public int _3947 { get; set; }
        public int _3948 { get; set; }
        public int _196 { get; set; }
        public int _3946 { get; set; }
        public int _6606 { get; set; }
        public int _23983 { get; set; }
        public int _197 { get; set; }
        public int _184 { get; set; }
        public int _191 { get; set; }
        public int _200 { get; set; }
        public int _182 { get; set; }
        public int _185 { get; set; }
        public int _858 { get; set; }
        public int _4596 { get; set; }
        public int _19809 { get; set; }
        public int _18641 { get; set; }
        public int _18705 { get; set; }
        public int _5590 { get; set; }
        public int _79 { get; set; }
        public int _589 { get; set; }
        public int _993 { get; set; }
        public int _1038 { get; set; }
        public int _19725 { get; set; }
        public int _18830 { get; set; }
        public int _19594 { get; set; }
        public int _18694 { get; set; }
        public int _19682 { get; set; }
        public int _19570 { get; set; }
        public int _23944 { get; set; }
        public int _16750 { get; set; }
        public int _258 { get; set; }
        public int _14245 { get; set; }
        public int _14246 { get; set; }
        public int _83 { get; set; }
        public int _911 { get; set; }
        public int _9358 { get; set; }
        public int _19846 { get; set; }
        public int _95 { get; set; }
        public int _820 { get; set; }
        public int _8155 { get; set; }
        public int _6916 { get; set; }
        public int _8122 { get; set; }
        public int _8136 { get; set; }
        public int _4081 { get; set; }
        public int _18791 { get; set; }
        public int _18812 { get; set; }
        public int _19688 { get; set; }
        public int _5952 { get; set; }
        public int _23533 { get; set; }
        public int _19580 { get; set; }
        public int _19558 { get; set; }
        public int _23188 { get; set; }
        public int _24344 { get; set; }
        public int _85 { get; set; }
        public int _84 { get; set; }
        public int _86 { get; set; }
        public int _77 { get; set; }
        public int _4955 { get; set; }
        public int _20050 { get; set; }
        public int _17269 { get; set; }
        public int _22591 { get; set; }
        public int _1182 { get; set; }
        public int _23512 { get; set; }
        public int _8251 { get; set; }
        public int _1096 { get; set; }
        public int _935 { get; set; }
        public int _963 { get; set; }
        public int _811 { get; set; }
        public int _10763 { get; set; }
        public int _849 { get; set; }
        public int _1041 { get; set; }
        public int _881 { get; set; }
        public int _797 { get; set; }
        public int _23850 { get; set; }
        public int _8051 { get; set; }
        public int _8128 { get; set; }
        public int _4110 { get; set; }
        public int _19825 { get; set; }
        public int _21153 { get; set; }
        public int _21156 { get; set; }
        public int _18851 { get; set; }
        public int _18598 { get; set; }
        public int _9824 { get; set; }
        public int _18666 { get; set; }
        public int _19604 { get; set; }
        public int _19721 { get; set; }
        public int _23894 { get; set; }
        public int _23910 { get; set; }
        public int _23897 { get; set; }
        public int _24320 { get; set; }
        public int _24311 { get; set; }
        public int _18797 { get; set; }
        public int _18795 { get; set; }
        public int _16749 { get; set; }
        public int _23890 { get; set; }
        public int _4085 { get; set; }
        public int _166 { get; set; }
        public int _15519 { get; set; }
        public int _1221 { get; set; }
        public int _22778 { get; set; }
        public int _19943 { get; set; }
        public int _19788 { get; set; }
        public int _19992 { get; set; }
        public int _261 { get; set; }
        public int _3931 { get; set; }
        public int _260 { get; set; }
        public int _3932 { get; set; }
        public int _6650 { get; set; }
        public int _22505 { get; set; }
        public int _22160 { get; set; }
        public int _4589 { get; set; }
        public int _23815 { get; set; }
        public int _23827 { get; set; }
        public int _19507 { get; set; }
        public int _19925 { get; set; }
        public int _19576 { get; set; }
        public int _183 { get; set; }
        public int _18609 { get; set; }
        public int _18600 { get; set; }
        public int _18599 { get; set; }
        public int _19504 { get; set; }
        public int _190 { get; set; }
        public int _630 { get; set; }
        public int _19537 { get; set; }
        public int _23928 { get; set; }
        public int _146 { get; set; }
        public int _18525 { get; set; }
        public int _147 { get; set; }
        public int _172 { get; set; }
        public int _18524 { get; set; }
        public int _871 { get; set; }
        public int _960 { get; set; }
        public int _9484 { get; set; }
        public int _1008 { get; set; }
        public int _8009 { get; set; }
        public int _23578 { get; set; }
        public int _8068 { get; set; }
        public int _637 { get; set; }
        public int _23562 { get; set; }
        public int _19497 { get; set; }
        public int _20021 { get; set; }
        public int _19866 { get; set; }
        public int _98 { get; set; }
        public int _97 { get; set; }
        public int _16751 { get; set; }
        public int _109 { get; set; }
        public int _1137 { get; set; }
        public int _7990 { get; set; }
        public int _24341 { get; set; }
        public int _6582 { get; set; }
        public int _20051 { get; set; }
        public int _21148 { get; set; }
        public int _16864 { get; set; }
        public int _108 { get; set; }
        public int _18532 { get; set; }
        public int _632 { get; set; }
        public int _4588 { get; set; }
        public int _4107 { get; set; }
        public int _19498 { get; set; }
        public int _80 { get; set; }
        public int _8012 { get; set; }
        public int _23747 { get; set; }
        public int _24360 { get; set; }
        public int _8668 { get; set; }
        public int _16764 { get; set; }
        public int _23750 { get; set; }
        public int _116 { get; set; }
        public int _3940 { get; set; }
        public int _757 { get; set; }
        public int _1209 { get; set; }
        public int _1194 { get; set; }
        public int _939 { get; set; }
        public int _822 { get; set; }
        public int _1072 { get; set; }
        public int _818 { get; set; }
        public int _907 { get; set; }
        public int _22299 { get; set; }
        public int _974 { get; set; }
        public int _883 { get; set; }
        public int _8120 { get; set; }
        public int _706 { get; set; }
        public int _5081 { get; set; }
        public int _1102 { get; set; }
        public int _19856 { get; set; }
        public int _18612 { get; set; }
        public int _18677 { get; set; }
        public int _18647 { get; set; }
        public int _18706 { get; set; }
        public int _18637 { get; set; }
        public int _19703 { get; set; }
        public int _19561 { get; set; }
        public int _23900 { get; set; }
        public int _24006 { get; set; }
        public int _23906 { get; set; }
        public int _22596 { get; set; }
        public int _24116 { get; set; }
        public int _24322 { get; set; }
        public int _24336 { get; set; }
        public int _23203 { get; set; }
        public int _24327 { get; set; }
        public int _8112 { get; set; }
        public int _19827 { get; set; }
        public int _113 { get; set; }
        public int _112 { get; set; }
        public int _8002 { get; set; }
        public int _19485 { get; set; }
        public int _19820 { get; set; }
        public int _20066 { get; set; }
        public int _19908 { get; set; }
        public int _918 { get; set; }
        public int _867 { get; set; }
        public int _809 { get; set; }
        public int _5947 { get; set; }
        public int _1006 { get; set; }
        public int _19566 { get; set; }
        public int _23899 { get; set; }
        public int _23914 { get; set; }
        public int _24004 { get; set; }
        public int _24329 { get; set; }
        public int _24343 { get; set; }
        public int _24340 { get; set; }
        public int _8005 { get; set; }
        public int _8086 { get; set; }
        public int _8117 { get; set; }
        public int _19830 { get; set; }
        public int _19927 { get; set; }
        public int _19521 { get; set; }
        public int _23912 { get; set; }
        public int _4111 { get; set; }
        public int _12670 { get; set; }
        public int _1150 { get; set; }
        public int _4595 { get; set; }
        public int _19538 { get; set; }
        public int _4591 { get; set; }
        public int _22502 { get; set; }
        public int _19554 { get; set; }
        public int _19980 { get; set; }
        public int _23825 { get; set; }
        public int _23826 { get; set; }
        public int _23071 { get; set; }
        public int _1076 { get; set; }
        public int _971 { get; set; }
        public int _8087 { get; set; }
        public int _24125 { get; set; }
        public int _23849 { get; set; }
        public int _890 { get; set; }
        public int _19804 { get; set; }
        public int _19716 { get; set; }
        public int _19551 { get; set; }
        public int _19710 { get; set; }
        public int _19543 { get; set; }
        public int _920 { get; set; }
        public int _66 { get; set; }
        public int _65 { get; set; }
        public int _943 { get; set; }
        public int _1002 { get; set; }
        public int _1005 { get; set; }
        public int _24680 { get; set; }
        public int _19938 { get; set; }
        public int _19805 { get; set; }
        public int _19797 { get; set; }
        public int _23982 { get; set; }
        public int _17801 { get; set; }
        public int _1152 { get; set; }
        public int _19954 { get; set; }
        public int _8095 { get; set; }
        public int _18605 { get; set; }
        public int _18658 { get; set; }
        public int _22663 { get; set; }
        public int _882 { get; set; }
        public int _927 { get; set; }
        public int _4599 { get; set; }
        public int _4083 { get; set; }
        public int _8605 { get; set; }
        public int _4080 { get; set; }
        public int _4629 { get; set; }
        public int _19505 { get; set; }
        public int _9829 { get; set; }
        public int _6806 { get; set; }
        public int _11115 { get; set; }
        public int _8761 { get; set; }
        public int _12822 { get; set; }
        public int _160 { get; set; }
        public int _819 { get; set; }
        public int _8263 { get; set; }
        public int _8085 { get; set; }
        public int _18813 { get; set; }
        public int _23579 { get; set; }
        public int _4590 { get; set; }
        public int _19919 { get; set; }
        public int _19819 { get; set; }
        public int _19556 { get; set; }
        public int _24342 { get; set; }
        public int _1175 { get; set; }
        public int _657 { get; set; }
        public int _1044 { get; set; }
        public int _879 { get; set; }
        public int _5018 { get; set; }
        public int _636 { get; set; }
        public int _22649 { get; set; }
        public int _22345 { get; set; }
        public int _24130 { get; set; }
        public int _19852 { get; set; }
        public int _18790 { get; set; }
        public int _791 { get; set; }
        public int _19724 { get; set; }
        public int _18507 { get; set; }
        public int _22499 { get; set; }
        public int _23870 { get; set; }
        public int _23072 { get; set; }
        public int _4600 { get; set; }
        public int _19706 { get; set; }
        public int _6304 { get; set; }
        public int _6687 { get; set; }
        public int _6303 { get; set; }
        public int _14205 { get; set; }
        public int _175 { get; set; }
        public int _174 { get; set; }
        public int _176 { get; set; }
        public int _173 { get; set; }
        public int _945 { get; set; }
        public int _21158 { get; set; }
        public int _19584 { get; set; }
        public int _23947 { get; set; }
        public int _8050 { get; set; }
        public int _4634 { get; set; }
        public int _3778 { get; set; }
        public int _9263 { get; set; }
        public int _18799 { get; set; }
        public int _4082 { get; set; }
        public int _16763 { get; set; }
        public int _13215 { get; set; }
        public int _11164 { get; set; }
        public int _3953 { get; set; }
        public int _3954 { get; set; }
        public int _3951 { get; set; }
        public int _3952 { get; set; }
        public int _187 { get; set; }
        public int _4742 { get; set; }
        public int _13331 { get; set; }
        public int _16760 { get; set; }
        public int _19697 { get; set; }
        public int _3824 { get; set; }
        public int _19833 { get; set; }
        public int _107 { get; set; }
        public int _24362 { get; set; }
        public int _783 { get; set; }
        public int _8004 { get; set; }
        public int _8077 { get; set; }
        public int _9817 { get; set; }
        public int _24145 { get; set; }
        public int _8118 { get; set; }
        public int _19484 { get; set; }
        public int _20047 { get; set; }
        public int _18652 { get; set; }
        public int _23911 { get; set; }
        public int _18847 { get; set; }
        public int _1048 { get; set; }
        public int _9830 { get; set; }
        public int _19924 { get; set; }
        public int _19694 { get; set; }
        public int _19611 { get; set; }
        public int _19715 { get; set; }
        public int _19705 { get; set; }
        public int _19511 { get; set; }
        public int _19582 { get; set; }
        public int _19572 { get; set; }
        public int _6518 { get; set; }
        public int _8977 { get; set; }
        public int _8976 { get; set; }
        public int _8974 { get; set; }
        public int _8975 { get; set; }
        public int _9000 { get; set; }
        public int _9003 { get; set; }
        public int _8997 { get; set; }
        public int _8998 { get; set; }
        public int _9001 { get; set; }
        public int _8999 { get; set; }
        public int _9002 { get; set; }
        public int _106 { get; set; }
        public int _995 { get; set; }
        public int _19488 { get; set; }
        public int _22340 { get; set; }
        public int _8075 { get; set; }
        public int _4958 { get; set; }
        public int _1186 { get; set; }
        public int _1153 { get; set; }
        public int _19845 { get; set; }
        public int _19918 { get; set; }
        public int _24100 { get; set; }
        public int _64 { get; set; }
        public int _18538 { get; set; }
        public int _1159 { get; set; }
        public int _19971 { get; set; }
        public int _204 { get; set; }
        public int _6307 { get; set; }
        public int _203 { get; set; }
        public int _19487 { get; set; }
        public int _169 { get; set; }
        public int _168 { get; set; }
        public int _170 { get; set; }
        public int _167 { get; set; }
        public int _1160 { get; set; }
        public int _18845 { get; set; }
        public int _20028 { get; set; }
        public int _23931 { get; set; }
        public int _931 { get; set; }
        public int _1219 { get; set; }
        public int _917 { get; set; }
        public int _3822 { get; set; }
        public int _20022 { get; set; }
        public int _19807 { get; set; }
        public int _19869 { get; set; }
        public int _19704 { get; set; }
        public int _17266 { get; set; }
        public int _4630 { get; set; }
        public int _8046 { get; set; }
        public int _23509 { get; set; }
        public int _19593 { get; set; }
        public int _18615 { get; set; }
        public int _18624 { get; set; }
        public int _23951 { get; set; }
        public int _192 { get; set; }
        public int _19917 { get; set; }
        public int _19518 { get; set; }
        public int _19519 { get; set; }
        public int _18530 { get; set; }
        public int _20048 { get; set; }
        public int _21149 { get; set; }
        public int _1136 { get; set; }
        public int _19808 { get; set; }
        public int _21145 { get; set; }
        public int _19678 { get; set; }
        public int _111 { get; set; }
        public int _8104 { get; set; }
        public int _14331 { get; set; }
        public int _6567 { get; set; }
        public int _12087 { get; set; }
        public int _16774 { get; set; }
        public int _18526 { get; set; }
        public int _994 { get; set; }
        public int _23577 { get; set; }
        public int _23954 { get; set; }
        public int _1223 { get; set; }
        public int _14183 { get; set; }
        public int _18539 { get; set; }
        public int _18540 { get; set; }
        public int _23612 { get; set; }
        public int _7279 { get; set; }
        public int _18639 { get; set; }
        public int _18640 { get; set; }
        public int _18697 { get; set; }
        public int _18692 { get; set; }
        public int _18703 { get; set; }
        public int _18662 { get; set; }
        public int _18679 { get; set; }
        public int _22804 { get; set; }
        public int _1063 { get; set; }
        public int _7989 { get; set; }
        public int _8069 { get; set; }
        public int _19539 { get; set; }
        public int _82 { get; set; }
        public int _19652 { get; set; }
        public int _19635 { get; set; }
        public int _19645 { get; set; }
        public int _3779 { get; set; }
        public int _5086 { get; set; }
        public int _8143 { get; set; }
        public int _8313 { get; set; }
        public int _23941 { get; set; }
        public int _10132 { get; set; }
        public int _163 { get; set; }
        public int _162 { get; set; }
        public int _733 { get; set; }
        public int _19928 { get; set; }
        public int _19761 { get; set; }
        public int _24398 { get; set; }
        public int _928 { get; set; }
        public int _19495 { get; set; }
        public int _20058 { get; set; }
        public int _179 { get; set; }
        public int _9794 { get; set; }
        public int _6621 { get; set; }
        public int _13363 { get; set; }
        public int _89 { get; set; }
        public int _90 { get; set; }
        public int _999 { get; set; }
        public int _24143 { get; set; }
        public int _63 { get; set; }
        public int _19859 { get; set; }
        public int _396 { get; set; }
        public int _19690 { get; set; }
        public int _23204 { get; set; }
        public int _8116 { get; set; }
        public int _19796 { get; set; }
        public int _19718 { get; set; }
        public int _71 { get; set; }
        public int _19490 { get; set; }
        public int _4594 { get; set; }
        public int _19986 { get; set; }
        public int _19817 { get; set; }
        public int _19847 { get; set; }
        public int _23958 { get; set; }
        public int _22675 { get; set; }
        public int _8126 { get; set; }
        public int _24109 { get; set; }
        public int _3933 { get; set; }
        public int _4635 { get; set; }
        public int _18753 { get; set; }
        public int _18752 { get; set; }
        public int _18751 { get; set; }
        public int _18750 { get; set; }
        public int _7675 { get; set; }
        public int _7664 { get; set; }
        public int _18749 { get; set; }
        public int _1022 { get; set; }
        public int _17249 { get; set; }
        public int _17708 { get; set; }
        public int _13102 { get; set; }
        public int _23920 { get; set; }
        public int _17391 { get; set; }
        public int _979 { get; set; }
        public int _22530 { get; set; }
        public int _22586 { get; set; }
        public int _22528 { get; set; }
        public int _22527 { get; set; }
        public int _22532 { get; set; }
        public int _22582 { get; set; }
        public int _22526 { get; set; }
        public int _22523 { get; set; }
        public int _22525 { get; set; }
        public int _22531 { get; set; }
        public int _626 { get; set; }
        public int _8045 { get; set; }
        public int _19826 { get; set; }
        public int _23190 { get; set; }
        public int _23192 { get; set; }
        public int _23205 { get; set; }
        public int _23865 { get; set; }
        public int _23878 { get; set; }
        public int _23862 { get; set; }
        public int _24313 { get; set; }
        public int _967 { get; set; }
        public int _22498 { get; set; }
        public int _1183 { get; set; }
        public int _23535 { get; set; }
        public int _8107 { get; set; }
        public int _19494 { get; set; }
        public int _23838 { get; set; }
        public int _23835 { get; set; }
        public int _23839 { get; set; }
        public int _19880 { get; set; }
        public int _19620 { get; set; }
        public int _23901 { get; set; }
        public int _873 { get; set; }
        public int _18712 { get; set; }
        public int _7997 { get; set; }
        public int _4598 { get; set; }
        public int _186 { get; set; }
        public int _23539 { get; set; }
        public int _9832 { get; set; }
        public int _7345 { get; set; }
        public int _3950 { get; set; }
        public int _532 { get; set; }
        public int _24126 { get; set; }
        public int _8142 { get; set; }
        public int _23833 { get; set; }
        public int _23829 { get; set; }
        public int _78 { get; set; }
        public int _5950 { get; set; }
        public int _18690 { get; set; }
        public int _19523 { get; set; }
        public int _5948 { get; set; }
        public int _1035 { get; set; }
        public int _8135 { get; set; }
        public int _19720 { get; set; }
        public int _18660 { get; set; }
        public int _23950 { get; set; }
        public int _15506 { get; set; }
        public int _13467 { get; set; }
        public int _9397 { get; set; }
        public int _11566 { get; set; }
        public int _19906 { get; set; }
        public int _19904 { get; set; }
        public int _164 { get; set; }
        public int _862 { get; set; }
        public int _865 { get; set; }
        public int _23935 { get; set; }
        public int _4633 { get; set; }
        public int _19545 { get; set; }
        public int _1023 { get; set; }
        public int _962 { get; set; }
        public int _19684 { get; set; }
        public int _19800 { get; set; }
        public int _18792 { get; set; }
        public int _18531 { get; set; }
        public int _4587 { get; set; }
        public int _23969 { get; set; }
        public int _7994 { get; set; }
        public int _19627 { get; set; }
        public int _20177 { get; set; }
        public int _4823 { get; set; }
        public int _4593 { get; set; }
        public int _4627 { get; set; }
        public int _19982 { get; set; }
        public int _19618 { get; set; }
        public int _23957 { get; set; }
        public int _4626 { get; set; }
        public int _24108 { get; set; }
        public int _23916 { get; set; }
        public int _75 { get; set; }
        public int _19903 { get; set; }
        public int _1040 { get; set; }
        public int _8062 { get; set; }
        public int _20179 { get; set; }
        public int _19970 { get; set; }
        public int _23937 { get; set; }
        public int _23877 { get; set; }
        public int _8006 { get; set; }
        public int _19631 { get; set; }
        public int _259 { get; set; }
        public int _171 { get; set; }
        public int _24141 { get; set; }
        public int _7991 { get; set; }
        public int _19496 { get; set; }
        public int _19849 { get; set; }
        public int _193 { get; set; }
        public int _759 { get; set; }
        public int _781 { get; set; }
        public int _656 { get; set; }
        public int _863 { get; set; }
        public int _19512 { get; set; }
        public int _22529 { get; set; }
        public int _8123 { get; set; }
        public int _20024 { get; set; }
        public int _24246 { get; set; }
        public int _8057 { get; set; }
        public int _22779 { get; set; }
        public int _23749 { get; set; }
        public int _8131 { get; set; }
        public int _19842 { get; set; }
        public int _18673 { get; set; }
        public int _19708 { get; set; }
        public int _23930 { get; set; }
        public int _24135 { get; set; }
        public int _1138 { get; set; }
        public int _18831 { get; set; }
        public int _20063 { get; set; }
        public int _19923 { get; set; }
        public int _18748 { get; set; }
        public int _23946 { get; set; }
        public int _14148 { get; set; }
        public int _8121 { get; set; }
        public int _24361 { get; set; }
        public int _18885 { get; set; }
        public int _19581 { get; set; }
        public int _19587 { get; set; }
        public int _19683 { get; set; }
        public int _1127 { get; set; }
        public int _5015 { get; set; }
        public int _708 { get; set; }
        public int _19816 { get; set; }
        public int _81 { get; set; }
        public int _839 { get; set; }
        public int _8063 { get; set; }
        public int _20481 { get; set; }
        public int _20178 { get; set; }
        public int _19090 { get; set; }
        public int _741 { get; set; }
        public int _1124 { get; set; }
        public int _24123 { get; set; }
        public int _23876 { get; set; }
        public int _19699 { get; set; }
        public int _18663 { get; set; }
        public int _24309 { get; set; }
        public int _24323 { get; set; }
        public int _8053 { get; set; }
        public int _19693 { get; set; }
        public int _19226 { get; set; }
        public int _19662 { get; set; }
        public int _19769 { get; set; }
        public int _19729 { get; set; }
        public int _19861 { get; set; }
        public int _17261 { get; set; }
        public int _14164 { get; set; }
        public int _23981 { get; set; }
        public int _19828 { get; set; }
        public int _623 { get; set; }
        public int _8081 { get; set; }
        public int _19759 { get; set; }
        public int _19792 { get; set; }
        public int _1133 { get; set; }
        public int _20064 { get; set; }
        public int _714 { get; set; }
        public int _19810 { get; set; }
        public int _19535 { get; set; }
        public int _19600 { get; set; }
        public int _19677 { get; set; }
        public int _19509 { get; set; }
        public int _19502 { get; set; }
        public int _19508 { get; set; }
        public int _19578 { get; set; }
        public int _24318 { get; set; }
        public int _18534 { get; set; }
        public int _1100 { get; set; }
        public int _6302 { get; set; }
        public int _847 { get; set; }
        public int _19765 { get; set; }
        public int _19757 { get; set; }
        public int _23742 { get; set; }
        public int _22337 { get; set; }
        public int _19621 { get; set; }
        public int _23514 { get; set; }
        public int _18832 { get; set; }
        public int _22579 { get; set; }
        public int _23537 { get; set; }
        public int _19815 { get; set; }
        public int _177 { get; set; }
        public int _178 { get; set; }
        public int _919 { get; set; }
        public int _22580 { get; set; }
        public int _891 { get; set; }
        public int _19637 { get; set; }
        public int _4631 { get; set; }
        public int _19628 { get; set; }
        public int _19836 { get; set; }
        public int _19607 { get; set; }
        public int _17392 { get; set; }
        public int _9249 { get; set; }
        public int _19754 { get; set; }
        public int _22335 { get; set; }
        public int _8056 { get; set; }
        public int _8130 { get; set; }
        public int _19834 { get; set; }
        public int _23956 { get; set; }
        public int _19689 { get; set; }
        public int _761 { get; set; }
        public int _944 { get; set; }
        public int _8138 { get; set; }
        public int _19089 { get; set; }
        public int _19515 { get; set; }
        public int _19548 { get; set; }
        public int _19873 { get; set; }
        public int _23968 { get; set; }
        public int _9892 { get; set; }
        public int _18681 { get; set; }
        public int _18591 { get; set; }
        public int _19685 { get; set; }
        public int _18747 { get; set; }
        public int _23952 { get; set; }
        public int _709 { get; set; }
        public int _180 { get; set; }
        public int _840 { get; set; }
        public int _23811 { get; set; }
        public int _19719 { get; set; }
        public int _19517 { get; set; }
        public int _19513 { get; set; }
        public int _859 { get; set; }
        public int _202 { get; set; }
        public int _6306 { get; set; }
        public int _257 { get; set; }
        public int _201 { get; set; }
        public int _19489 { get; set; }
        public int _19681 { get; set; }
        public int _8010 { get; set; }
        public int _8021 { get; set; }
        public int _19855 { get; set; }
        public int _21155 { get; set; }
        public int _19793 { get; set; }
        public int _19560 { get; set; }
        public int _19661 { get; set; }
        public int _19615 { get; set; }
        public int _62 { get; set; }
        public int _1091 { get; set; }
        public int _19768 { get; set; }
        public int _19871 { get; set; }
        public int _24243 { get; set; }
        public int _721 { get; set; }
        public int _844 { get; set; }
        public int _19956 { get; set; }
        public int _105 { get; set; }
        public int _100 { get; set; }
        public int _19756 { get; set; }
        public int _23847 { get; set; }
        public int _19567 { get; set; }
        public int _4636 { get; set; }
        public int _20014 { get; set; }
        public int _23517 { get; set; }
        public int _1161 { get; set; }
        public int _7999 { get; set; }
        public int _19732 { get; set; }
        public int _24128 { get; set; }
        public int _24127 { get; set; }
        public int _4586 { get; set; }
        public int _24124 { get; set; }
        public int _19755 { get; set; }
        public int _19790 { get; set; }
        public int _1125 { get; set; }
        public int _734 { get; set; }
        public int _929 { get; set; }
        public int _20013 { get; set; }
        public int _19218 { get; set; }
        public int _19692 { get; set; }
        public int _4597 { get; set; }
        public int _19942 { get; set; }
        public int _19950 { get; set; }
        public int _24244 { get; set; }
        public int _19811 { get; set; }
        public int _19851 { get; set; }
        public int _19850 { get; set; }
        public int _18628 { get; set; }
        public int _19506 { get; set; }
        public int _801 { get; set; }
        public int _856 { get; set; }
        public int _19860 { get; set; }
        public int _19858 { get; set; }
        public int _764 { get; set; }
        public int _24418 { get; set; }
        public int _23940 { get; set; }
        public int _1065 { get; set; }
        public int _19633 { get; set; }
        public int _5949 { get; set; }
        public int _8001 { get; set; }
        public int _8119 { get; set; }
        public int _9185 { get; set; }
        public int _19760 { get; set; }
        public int _8106 { get; set; }
        public int _19822 { get; set; }
        public int _8140 { get; set; }
        public int _1130 { get; set; }
        public int _8072 { get; set; }
        public int _23187 { get; set; }
        public int _23688 { get; set; }
        public int _16737 { get; set; }
        public int _19991 { get; set; }
        public int _19840 { get; set; }
        public int _3949 { get; set; }
        public int _10682 { get; set; }
        public int _10681 { get; set; }
        public int _20059 { get; set; }
        public int _22339 { get; set; }
        public int _18642 { get; set; }
        public int _18618 { get; set; }
        public int _19881 { get; set; }
        public int _19922 { get; set; }
        public int _19579 { get; set; }
        public int _8109 { get; set; }
        public int _4604 { get; set; }
        public int _20019 { get; set; }
        public int _17264 { get; set; }
        public int _750 { get; set; }
        public int _4605 { get; set; }
        public int _19589 { get; set; }
        public int _23745 { get; set; }
        public int _23976 { get; set; }
        public int _23977 { get; set; }
        public int _19491 { get; set; }
        public int _24113 { get; set; }
        public int _19657 { get; set; }
        public int _1178 { get; set; }
        public int _964 { get; set; }
        public int _19588 { get; set; }
        public int _23933 { get; set; }
        public int _19823 { get; set; }
        public int _8103 { get; set; }
        public int _7350 { get; set; }
        public int _19695 { get; set; }
        public int _19676 { get; set; }
        public int _23557 { get; set; }
        public int _1154 { get; set; }
        public int _21146 { get; set; }
        public int _19617 { get; set; }
        public int _949 { get; set; }
        public int _19821 { get; set; }
        public int _19526 { get; set; }
        public int _19988 { get; set; }
        public int _19605 { get; set; }
        public int _22803 { get; set; }
        public int _24144 { get; set; }
        public int _22583 { get; set; }
        public int _19598 { get; set; }
        public int _23746 { get; set; }
        public int _19814 { get; set; }
        public int _19829 { get; set; }
        public int _19522 { get; set; }
        public int _19801 { get; set; }
        public int _19766 { get; set; }
        public int _19544 { get; set; }
        public int _13483 { get; set; }
        public int _19812 { get; set; }
        public int _19709 { get; set; }
        public int _19839 { get; set; }
        public int _20045 { get; set; }
        public int _20008 { get; set; }
        public int _19789 { get; set; }
        public int _23955 { get; set; }
        public int _23868 { get; set; }
        public int _16759 { get; set; }
        public int _3823 { get; set; }
        public int _1066 { get; set; }
        public int _19898 { get; set; }
        public int _19555 { get; set; }
        public int _19503 { get; set; }
        public int _19806 { get; set; }
        public int _19714 { get; set; }
        public int _19764 { get; set; }
        public int _1104 { get; set; }
        public int _19853 { get; set; }
        public int _19848 { get; set; }
        public int _20017 { get; set; }
        public int _20009 { get; set; }
        public int _19727 { get; set; }
        public int _19609 { get; set; }
        public int _19533 { get; set; }
        public int _23979 { get; set; }
        public int _23532 { get; set; }
        public int _24137 { get; set; }
        public int _20025 { get; set; }
        public int _19728 { get; set; }
        public int _19701 { get; set; }
        public int _848 { get; set; }
        public int _4821 { get; set; }
        public int _19647 { get; set; }
        public int _20046 { get; set; }
        public int _19602 { get; set; }
        public int _7995 { get; set; }
        public int _22781 { get; set; }
        public int _23974 { get; set; }
        public int _19608 { get; set; }
        public int _23744 { get; set; }
        public int _4608 { get; set; }
        public int _5495 { get; set; }
        public int _762 { get; set; }
        public int _788 { get; set; }
        public int _18850 { get; set; }
        public int _19887 { get; set; }
        public int _5946 { get; set; }
        public int _19529 { get; set; }
        public int _19553 { get; set; }
        public int _19879 { get; set; }
        public int _10603 { get; set; }
        public int _23978 { get; set; }
        public int _19649 { get; set; }
        public int _19698 { get; set; }
        public int _19870 { get; set; }
        public int _19722 { get; set; }
        public int _19590 { get; set; }
        public int _735 { get; set; }
        public int _831 { get; set; }
        public int _19799 { get; set; }
        public int _14378 { get; set; }
        public int _11490 { get; set; }
        public int _4271 { get; set; }
        public int _9192 { get; set; }
        public int _7992 { get; set; }
        public int _4601 { get; set; }
        public int _19648 { get; set; }
        public int _19798 { get; set; }
        public int _19534 { get; set; }
        public int _19626 { get; set; }
        public int _23970 { get; set; }
        public int _19762 { get; set; }
        public int _7683 { get; set; }
        public int _23942 { get; set; }
        public int _20016 { get; set; }
        public int _21150 { get; set; }
        public int _19525 { get; set; }
        public int _19654 { get; set; }
        public int _19499 { get; set; }
        public int _19656 { get; set; }
        public int _8134 { get; set; }
        public int _19514 { get; set; }
        public int _8079 { get; set; }
        public int _9421 { get; set; }
        public int _11093 { get; set; }
        public int _5954 { get; set; }
        public int _19624 { get; set; }
        public int _4103 { get; set; }
        public int _9724 { get; set; }
        public int _14093 { get; set; }
        public int _18707 { get; set; }
        public int _19541 { get; set; }
        public int _24119 { get; set; }
        public int _19569 { get; set; }
        public int _19975 { get; set; }
        public int _23975 { get; set; }
        public int _8048 { get; set; }
        public int _7998 { get; set; }
        public int _19632 { get; set; }
        public int _23971 { get; set; }
        public int _3827 { get; set; }
        public int _5492 { get; set; }
        public int _5491 { get; set; }
        public int _5496 { get; set; }
        public int _4269 { get; set; }
        public int _5490 { get; set; }
        public int _9631 { get; set; }
        public int _13240 { get; set; }
        public int _9244 { get; set; }
        public int _24174 { get; set; }
        public int _24173 { get; set; }
        public int _24198 { get; set; }
        public int _5494 { get; set; }
        public int _19651 { get; set; }
        public int _19643 { get; set; }
        public int _4603 { get; set; }
        public int _20056 { get; set; }
        public int _22584 { get; set; }
        public int _20055 { get; set; }
        public int _19562 { get; set; }
        public int _19585 { get; set; }
        public int _455 { get; set; }
        public int _8963 { get; set; }
        public int _19540 { get; set; }
        public int _19899 { get; set; }
        public int _20015 { get; set; }
        public int _23948 { get; set; }
        public int _19900 { get; set; }
        public int _8316 { get; set; }
        public int _19646 { get; set; }
        public int _4114 { get; set; }
        public int _20011 { get; set; }
        public int _20062 { get; set; }
        public int _19889 { get; set; }
        public int _19713 { get; set; }
        public int _19767 { get; set; }
        public int _22546 { get; set; }
        public int _19902 { get; set; }
        public int _8139 { get; set; }
        public int _4610 { get; set; }
        public int _19795 { get; set; }
        public int _19832 { get; set; }
        public int _24102 { get; set; }
        public int _8314 { get; set; }
        public int _22650 { get; set; }
        public int _8052 { get; set; }
        public int _19696 { get; set; }
        public int _19606 { get; set; }
        public int _9813 { get; set; }
        public int _748 { get; set; }
        public int _19658 { get; set; }
        public int _4820 { get; set; }
        public int _23938 { get; set; }
        public int _18883 { get; set; }
        public int _17254 { get; set; }
        public int _19638 { get; set; }
        public int _7996 { get; set; }
        public int _4609 { get; set; }
        public int _19642 { get; set; }
        public int _19640 { get; set; }
        public int _4632 { get; set; }
        public int _19838 { get; set; }
        public int _19794 { get; set; }
        public int _23875 { get; set; }
    }

    public class Displayed_Phones
    {
        public int display_type { get; set; }
        public string[] numbers { get; set; }
    }

    public class Min_Price_Data
    {
        public int hotel_id { get; set; }
        public float price { get; set; }
        public string currency { get; set; }
        public string _in { get; set; }
        public string _out { get; set; }
        public int has_free { get; set; }
        public string updated { get; set; }
        public string current_price_date { get; set; }
        public int room_id { get; set; }
        public string placement_id { get; set; }
    }

    public class Category_Index
    {
        public int _1 { get; set; }
        public int _2 { get; set; }
        public int _3 { get; set; }
        public int _4 { get; set; }
        public int _5 { get; set; }
        public int _6 { get; set; }
        public int _7 { get; set; }
        public int _8 { get; set; }
    }

    public class Valid_Filter
    {
        public int[] categories { get; set; }
        public object service { get; set; }
        public int hotel_like_hostel_price { get; set; }
        public int online_payment { get; set; }
        public int bonus_payment { get; set; }
        public int no_card_required { get; set; }
        public int without_children { get; set; }
        public int partner_for_seo { get; set; }
    }

    public class Image1
    {
        public string path { get; set; }
        public string thumb_path { get; set; }
        public string preview_path { get; set; }
        public string type { get; set; }
        public int?[] type_ids { get; set; }
    }

    public class Area
    {
        public string type { get; set; }
        public int id { get; set; }
        public int is_main { get; set; }
    }

    public class Booking_Areas
    {
        public int id { get; set; }
        public object context { get; set; }
    }

}
