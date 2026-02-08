import React, { useEffect, useState } from 'react';
import axios from 'axios';

const App = () => {
  const [groups, setGroups] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    axios.get('http://localhost:5000/api/subscriptions')
      .then(response => {
        setGroups(response.data);
        setLoading(false);
      })
      .catch(err => {
        console.error('Eroare Axios:', err);
        setError(err.message);
        setLoading(false);
      });
  }, []);

  if (loading) return <div className="text-center p-12">Se încarcă...</div>;
  if (error) return <div className="text-center p-12 text-red-600">Eroare: {error}</div>;

  return (
    <div className="max-w-6xl mx-auto p-8">
      <h1 className="text-3xl font-bold text-center mb-10">Abonamente la sală</h1>

      {groups.map((group) => (
        <div key={group.id} className="mb-8">
          {/* Header */}
          <div 
            className="p-4 text-white rounded-t"
            style={{ background: group.colorTheme }}
          >
            <h2 className="text-xl font-bold">{group.name}</h2>
            <p className="text-sm">{group.schedule}</p>
          </div>

          {/* Plans */}
          <div className="border border-gray-300 rounded-b p-4 grid grid-cols-2 md:grid-cols-4 gap-4">
            {group.plans.map((plan) => (
              <div key={plan.id} className="border p-4 rounded text-center">
                <p className="font-semibold">{plan.title}</p>
                <p className="text-2xl font-bold text-red-600">{plan.totalPrice} mdl</p>
                <p className="text-xs text-gray-500">{plan.pricingInfo}</p>
                <button className="mt-3 border border-red-600 text-red-600 px-4 py-1 rounded hover:bg-red-600 hover:text-white">
                  Cumpără
                </button>
              </div>
            ))}
          </div>
        </div>
      ))}
    </div>
  );
};

export default App;